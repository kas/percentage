using IconLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            // battery
            settings = CustomSettings.Instance;
            batteryFontText.Text = settings.fontName + ", " + settings.fontSize;
            batteryFontDialog.Font = new Font(settings.fontName, settings.fontSize);
            batteryScaling.Checked = settings.scaling > 0;
            batteryForegroundText.Text = Utils.ColorToString(settings.foregroundColor);
            batteryForegroundOpacity.Value = settings.foregroundColor.A;
            batteryBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            batteryBackgroundOpacity.Value = settings.backgroundColor.A;
            batteryBorderText.Text = Utils.ColorToString(settings.borderColor);
            batteryBorderOpacity.Value = settings.borderColor.A;
            batteryInterval.Value = settings.updateInterval;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // battery
            settings.fontName = batteryFontDialog.Font.Name;
            settings.fontSize = Convert.ToInt32(batteryFontDialog.Font.Size);
            settings.scaling = Convert.ToInt32(batteryScaling.Checked);
            settings.foregroundColor = Utils.ColorFromString(batteryForegroundText.Text);
            settings.backgroundColor = Utils.ColorFromString(batteryBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(batteryBorderText.Text);
            settings.updateInterval = (int)batteryInterval.Value;

            Close();
        }

        // battery
        private void batteryFontButton_Click(object sender, EventArgs e)
        {
            Font font = new Font(settings.fontName, settings.fontSize);
            batteryFontDialog.Font = font;
            batteryFontDialog.ShowDialog();
            batteryFontText.Text = batteryFontDialog.Font.Name + ", " + Convert.ToInt32(batteryFontDialog.Font.Size);
        }

        private void batteryForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(batteryForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(batteryForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            batteryForegroundText.Text = Utils.ColorToString(color);
        }

        private void batteryBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(batteryBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(batteryBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            batteryBackgroundText.Text = Utils.ColorToString(color);
        }

        private void batteryBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(batteryBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(batteryBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            batteryBorderText.Text = Utils.ColorToString(color);
        }

        private void batteryForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(batteryForegroundText.Text);
            Color color2 = Color.FromArgb(batteryForegroundOpacity.Value, color.R, color.G, color.B);
            batteryForegroundText.Text = Utils.ColorToString(color2);
        }

        private void batteryBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(batteryBackgroundText.Text);
            Color color2 = Color.FromArgb(batteryBackgroundOpacity.Value, color.R, color.G, color.B);
            batteryBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void batteryBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(batteryBorderText.Text);
            Color color2 = Color.FromArgb(batteryBorderOpacity.Value, color.R, color.G, color.B);
            batteryBorderText.Text = Utils.ColorToString(color2);
        }

    }
}
