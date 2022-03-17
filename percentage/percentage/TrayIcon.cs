using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace percentage
{
    class TrayIcon
    {
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        static extern bool DestroyIcon(IntPtr handle);

        private const int fontSize = 18;
        private const string font = "Segoe UI";
        private Color fontColor = Color.Black;

        private NotifyIcon notifyIcon;

        public TrayIcon()
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem();

            notifyIcon = new NotifyIcon();

            contextMenu.MenuItems.AddRange(new MenuItem[] { menuItem });

            menuItem.Click += new System.EventHandler(MenuItemClick);
            menuItem.Index = 0;
            menuItem.Text = "E&xit";

            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private Bitmap GetTextBitmap(String text, Font font, Color fontColor)
        {
            SizeF imageSize = GetStringImageSize(text, font);
            Bitmap bitmap = new Bitmap((int)imageSize.Width, (int)imageSize.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.FromArgb(0, 0, 0, 0));
                using (Brush brush = new SolidBrush(fontColor))
                {
                    graphics.DrawString(text, font, brush, 0, 0);
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    graphics.Save();
                }
            }
            return bitmap;
        }

        // true为深色模式 反之false
        private static bool GetWindowsTheme()
        {
            const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            // 获取应用的颜色模式
            //const string RegistryValueName = "AppsUseLightTheme";
            // 获取系统的颜色模式
            const string RegistryValueName = "SystemUsesLightTheme";
            // 这里也可能是LocalMachine(HKEY_LOCAL_MACHINE)
            // see "https://www.addictivetips.com/windows-tips/how-to-enable-the-dark-theme-in-windows-10/"
            object registryValueObject = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegistryKeyPath)?.GetValue(RegistryValueName);
            if (registryValueObject is null)
                return false;

            return (int)registryValueObject > 0 ? false : true;
        }

        private static SizeF GetStringImageSize(string text, Font font)
        {
            using (Image image = new Bitmap(1, 1))
            using (Graphics graphics = Graphics.FromImage(image))
                return graphics.MeasureString(text, font);
        }

        private void MenuItemClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            String percentage = (powerStatus.BatteryLifePercent * 100).ToString();
            bool isCharging = powerStatus.PowerLineStatus == PowerLineStatus.Online;
            String bitmapText = powerStatus.BatteryLifePercent < 1 ? ((int)(powerStatus.BatteryLifePercent * 100)).ToString("D2") : "00";

            if (GetWindowsTheme())
            {
                if (fontColor != Color.White)
                {
                    fontColor = Color.White;
                }
            }
            else
            {
                if (fontColor != Color.Black)
                {
                    fontColor = Color.Black;
                }
            }

            using (Bitmap bitmap = new Bitmap(GetTextBitmap(bitmapText, new Font(font, fontSize), fontColor)))
            {
                System.IntPtr intPtr = bitmap.GetHicon();
                try
                {
                    using (Icon icon = Icon.FromHandle(intPtr))
                    {
                        notifyIcon.Icon = icon;
                        String toolTipText = percentage + "%" + (isCharging ? " Charging" : "");
                        notifyIcon.Text = toolTipText;
                    }
                }
                finally
                {
                    DestroyIcon(intPtr);
                }
            }
        }
    }
}
