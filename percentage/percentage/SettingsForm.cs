using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percentage
{
    public partial class SettingsForm : Form
    {
        Settings settings;

        public SettingsForm()
        {
            InitializeComponent();
            settings = Settings.Instance;
            textForeground.Text = Utils.ColorToString(settings.foregroundColor);
            textBackground.Text = Utils.ColorToString(settings.backgroundColor);
            textBorder.Text = Utils.ColorToString(settings.borderColor);
            sliderForeground.Value = settings.foregroundColor.A;
            sliderBackground.Value = settings.backgroundColor.A;
            sliderBorder.Value = settings.borderColor.A;
            textFont.Text = settings.fontName + ", " + settings.fontSize;
            fontDialog1.Font = new Font(settings.fontName, settings.fontSize);
            numericUpdateInterval.Value = settings.updateInterval;
        }

        private void buttonEditForeground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Utils.ColorFromString(textForeground.Text);
            colorDialog1.FullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();
            Color color = Color.FromArgb(sliderForeground.Value, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            textForeground.Text = Utils.ColorToString(color);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            settings.foregroundColor = Utils.ColorFromString(textForeground.Text);
            settings.backgroundColor = Utils.ColorFromString(textBackground.Text);
            settings.borderColor = Utils.ColorFromString(textBorder.Text);
            settings.fontName = fontDialog1.Font.Name;
            settings.fontSize = Convert.ToInt32(fontDialog1.Font.Size);
            settings.updateInterval = (int)numericUpdateInterval.Value;
            Close();
        }

        private void buttonEditFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowHelp = false;
            fontDialog1.AllowScriptChange = false;
            fontDialog1.ShowEffects = false;

            Font font = new Font(settings.fontName, settings.fontSize);
            fontDialog1.Font = font;

            fontDialog1.ShowDialog();
            textFont.Text = fontDialog1.Font.Name + ", " + Convert.ToInt32(fontDialog1.Font.Size);

        }

        private void buttonEditBackground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Utils.ColorFromString(textBackground.Text);
            colorDialog1.FullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();
            Color color = Color.FromArgb(sliderBackground.Value, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            textBackground.Text = Utils.ColorToString(color);
        }

        private void sliderForeground_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(textForeground.Text);
            Color color2 = Color.FromArgb(sliderForeground.Value, color.R, color.G, color.B);
            textForeground.Text = Utils.ColorToString(color2);
        }

        private void sliderBackground_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(textBackground.Text);
            Color color2 = Color.FromArgb(sliderBackground.Value, color.R, color.G, color.B);
            textBackground.Text = Utils.ColorToString(color2);
        }

        private void buttonEditBorder_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Utils.ColorFromString(textBorder.Text);
            colorDialog1.FullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();
            Color color = Color.FromArgb(sliderBorder.Value, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            textBorder.Text = Utils.ColorToString(color);
        }

        private void sliderBorder_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(textBorder.Text);
            Color color2 = Color.FromArgb(sliderBorder.Value, color.R, color.G, color.B);
            textBorder.Text = Utils.ColorToString(color2);
        }
    }
}
