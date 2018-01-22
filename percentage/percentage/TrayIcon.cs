using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace percentage
{
    class TrayIcon
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool DestroyIcon(IntPtr handle);
        private const string iconFont = "Segoe UI";
        private const int iconFontSize = 14;
        private string batteryPercentage;
        private NotifyIcon notifyIcon;

        private int refreshInterval = 1000; // in miliseconds

        public TrayIcon()
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem();

            notifyIcon = new NotifyIcon();

            // initialize contextMenu
            contextMenu.MenuItems.AddRange(new MenuItem[] { menuItem });

            // initialize menuItem
            menuItem.Index = 0;
            menuItem.Text = "Exit";
            menuItem.Click += new System.EventHandler(menuItem_Click);
            notifyIcon.ContextMenu = contextMenu;
            batteryPercentage = "?";
            notifyIcon.Visible = true;

            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = refreshInterval; 
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            batteryPercentage = (powerStatus.BatteryLifePercent * 100).ToString();
            
            using (Bitmap bitmap = new Bitmap(DrawText(batteryPercentage, new Font(iconFont, iconFontSize), Color.White, Color.Transparent)))
            {
                System.IntPtr intPtr = bitmap.GetHicon();
                try
                {
                    using (Icon icon = Icon.FromHandle(intPtr))
                    {
                        // Offline means the laptop is not connected to a power source
                        if (powerStatus.PowerLineStatus.ToString().Equals("Offline")) {
                            notifyIcon.Icon = icon;
                            var ts = TimeSpan.FromSeconds(powerStatus.BatteryLifeRemaining);
                            
                            // if you don't want the leading zeros, you can replace the format by '{0}:{1}'
                            notifyIcon.Text = string.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes);
                        } else {
                            notifyIcon.Icon = icon;
                            notifyIcon.Text = "Charging";
                        }
                    }
                }
                finally
                {
                    DestroyIcon(intPtr);
                }
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            var textSize = GetImageSize(text, font);
            Image image = new Bitmap((int) textSize.Width, (int) textSize.Height);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                // paint the background
                graphics.Clear(backColor);

                // create a brush for the text
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    graphics.DrawString(text, font, textBrush, 0, 0);
                    graphics.Save();
                }
            }

            return image;
        }

        private static SizeF GetImageSize(string text, Font font)
        {
            using (Image image = new Bitmap(1, 1))
            using (Graphics graphics = Graphics.FromImage(image))
                return graphics.MeasureString(text, font);
        }
    }
}
