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

        private string batteryPercentage;
        private NotifyIcon notifyIcon;

        private Settings settings;

        public TrayIcon()
        {
            settings = new Settings();

            notifyIcon = new NotifyIcon();

            // initialize contextMenu
            notifyIcon.ContextMenu = new ContextMenu(new[]
            {
                new MenuItem("&Settings", menuSettings_Click),
                new MenuItem("E&xit", menuExit_Click),
                
            });

            notifyIcon.Visible = true;

            Timer timer = new Timer();
            timer.Tick += new EventHandler(UpdateIcon);
            timer.Interval = settings.updateInterval;
            timer.Start();
            // show icon immediatly after start because timer interval can be large
            UpdateIcon(timer, null);
        }

        private void UpdateIcon(object sender, EventArgs e)
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;

            batteryPercentage = (powerStatus.BatteryLifePercent * 100).ToString();

            string iconFont = settings.fontName;
            int iconFontSize = settings.fontSize;
            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;

            using (Bitmap bitmap = new Bitmap(DrawText(batteryPercentage, new Font(iconFont, iconFontSize, FontStyle.Bold), foregroundColor, backgroundColor)))
            {
                System.IntPtr intPtr = bitmap.GetHicon();
                try
                {
                    using (Icon icon = Icon.FromHandle(intPtr))
                    {
                        notifyIcon.Icon = icon;
                        if (powerStatus.BatteryLifeRemaining != -1)
                        {
                            if (powerStatus.BatteryLifeRemaining > 3600)
                            {
                                int hours = powerStatus.BatteryLifeRemaining / 3600;
                                int minutes = powerStatus.BatteryLifeRemaining % 3600 / 60;
                                notifyIcon.Text = String.Format("{0} hr {1} min ({2}%) remaining", hours, minutes, batteryPercentage);
                            }
                            else
                            {
                                int minutes = powerStatus.BatteryLifeRemaining / 60;
                                notifyIcon.Text = String.Format("{0} min ({1}%) remaining", minutes, batteryPercentage);
                            }
                        }
                        else
                        {
                            notifyIcon.Text = String.Format("{0}%", batteryPercentage);
                        }
                        if (powerStatus.BatteryChargeStatus == BatteryChargeStatus.Charging)
                        {
                            notifyIcon.Text += " (charging)";
                        }
                    }
                }
                finally
                {
                    DestroyIcon(intPtr);
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
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

        private void menuSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            // flush cached settings
            settings.Reload();
            // immediatly update icon to apply changes
            UpdateIcon(sender, e);
        }
    }
}
