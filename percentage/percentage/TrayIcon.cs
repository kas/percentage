using System;
using System.Drawing;
using System.Windows.Forms;

namespace percentage
{
    class TrayIcon
    {
        private const string iconFont = "Segoe UI";
        private const int iconFontSize = 14;

        private string batteryPercentage;
        private NotifyIcon notifyIcon;

        public TrayIcon()
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem();

            notifyIcon = new NotifyIcon();

            // initialize contextMenu
            contextMenu.MenuItems.AddRange(new MenuItem[] { menuItem });

            // initialize menuItem
            menuItem.Index = 0;
            menuItem.Text = "E&xit";
            menuItem.Click += new System.EventHandler(menuItem_Click);

            notifyIcon.ContextMenu = contextMenu;

            batteryPercentage = "?";

            notifyIcon.Visible = true;

            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // in miliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            batteryPercentage = (powerStatus.BatteryLifePercent * 100).ToString();

            Bitmap img = new Bitmap(DrawText(batteryPercentage, new Font(iconFont, iconFontSize), Color.White, Color.Black));

            System.IntPtr icH = img.GetHicon();
            Icon ico = Icon.FromHandle(icH);

            notifyIcon.Icon = ico;
            notifyIcon.Text = batteryPercentage + "%";
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            // create a dummy bitmap to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            // measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            // free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            // create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            // paint the background
            drawing.Clear(backColor);

            // create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;
        }
    }
}
