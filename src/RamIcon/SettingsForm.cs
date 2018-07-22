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

namespace RamIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            // ram
            settings = CustomSettings.Instance;
            ramPointWidth.SelectedIndex = ramPointWidth.FindStringExact(settings.pointWidth.ToString());
            ramForegroundText.Text = Utils.ColorToString(settings.foregroundColor);
            ramForegroundOpacity.Value = settings.foregroundColor.A;
            ramBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            ramBackgroundOpacity.Value = settings.backgroundColor.A;
            ramBorderText.Text = Utils.ColorToString(settings.borderColor);
            ramBorderOpacity.Value = settings.borderColor.A;
            ramInterval.Value = settings.updateInterval;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ram
            if (ramPointWidth.SelectedIndex >= 0)
                settings.pointWidth = Convert.ToInt32(ramPointWidth.Items[ramPointWidth.SelectedIndex]);
            settings.foregroundColor = Utils.ColorFromString(ramForegroundText.Text);
            settings.backgroundColor = Utils.ColorFromString(ramBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(ramBorderText.Text);
            settings.updateInterval = (int)ramInterval.Value;
            
            Close();
        }
        
        // ram
        private void ramForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(ramForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(ramForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            ramForegroundText.Text = Utils.ColorToString(color);
        }

        private void ramBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(ramBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(ramBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            ramBackgroundText.Text = Utils.ColorToString(color);
        }

        private void ramBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(ramBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(ramBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            ramBorderText.Text = Utils.ColorToString(color);
        }

        private void ramForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(ramForegroundText.Text);
            Color color2 = Color.FromArgb(ramForegroundOpacity.Value, color.R, color.G, color.B);
            ramForegroundText.Text = Utils.ColorToString(color2);
        }

        private void ramBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(ramBackgroundText.Text);
            Color color2 = Color.FromArgb(ramBackgroundOpacity.Value, color.R, color.G, color.B);
            ramBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void ramBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(ramBorderText.Text);
            Color color2 = Color.FromArgb(ramBorderOpacity.Value, color.R, color.G, color.B);
            ramBorderText.Text = Utils.ColorToString(color2);
        }

    }
}
