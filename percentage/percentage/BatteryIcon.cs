using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace percentage
{
    class BatteryIcon: TrayIcon
    {
        private SettingsBattery settings;

        public BatteryIcon()
        {
            settings = SettingsBattery.Instance;
            if (settings.enabled <= 0)
            {
                DisableIcon();
                return;
            }

            SetUpdateInterval(settings.updateInterval);
            // show icon immediatly after start because timer interval can be large
            UpdateIcon(null, null);
        }

        public override void UpdateIcon(object sender, EventArgs e)
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;

            string batteryPercentage = (powerStatus.BatteryLifePercent * 100).ToString();

            string tooltip;
            if (powerStatus.BatteryLifeRemaining != -1)
            {
                if (powerStatus.BatteryLifeRemaining > 3600)
                {
                    int hours = powerStatus.BatteryLifeRemaining / 3600;
                    int minutes = powerStatus.BatteryLifeRemaining % 3600 / 60;
                    tooltip = String.Format("{0} hr {1} min ({2}%) remaining", hours, minutes, batteryPercentage);
                }
                else
                {
                    int minutes = powerStatus.BatteryLifeRemaining / 60;
                    tooltip = String.Format("{0} min ({1}%) remaining", minutes, batteryPercentage);
                }
            }
            else
            {
                tooltip = String.Format("{0}%", batteryPercentage);
            }
            if (powerStatus.BatteryChargeStatus == BatteryChargeStatus.Charging)
            {
                tooltip += " (charging)";
            }

            string iconFont = settings.fontName;
            int iconFontSize = settings.fontSize;
            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;

            using (Bitmap bitmap = new Bitmap(DrawText(batteryPercentage, new Font(iconFont, iconFontSize, FontStyle.Bold), foregroundColor, backgroundColor, borderColor)))
            {
                ChangeIcon(bitmap, tooltip);
            }
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor, Color borderColor)
        {
            var textSize = GetImageSize(text, font);
            int iconSize = GetSmallIconSize();
            Image image = new Bitmap(iconSize, iconSize);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                // paint the background
                graphics.Clear(backColor);

                // create a brush for the text
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    graphics.DrawString(text, font, textBrush, (image.Width - textSize.Width) / 2, (image.Height - textSize.Height) / 2);

                    int borderWidth = 1;
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)image.Width - borderWidth, (int)image.Height - borderWidth);

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

        protected override void menuSettings_Click(object sender, EventArgs e)
        {
            base.menuSettings_Click(sender, e);
            SetUpdateInterval(settings.updateInterval);
        }
    }
}
