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

namespace NetIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            // network
            settings = CustomSettings.Instance;
            networkPointWidth.SelectedIndex = networkPointWidth.FindStringExact(settings.pointWidth.ToString());
            networkForegroundText.Text = Utils.ColorToString(settings.foregroundColor);
            networkForegroundOpacity.Value = settings.foregroundColor.A;
            networkBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            networkBackgroundOpacity.Value = settings.backgroundColor.A;
            networkBorderText.Text = Utils.ColorToString(settings.borderColor);
            networkBorderOpacity.Value = settings.borderColor.A;
            networkInterval.Value = settings.updateInterval;
            networkMaxBandwidth.Value = settings.maxBandwith;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // network
            if (networkPointWidth.SelectedIndex >= 0)
                settings.pointWidth = Convert.ToInt32(networkPointWidth.Items[networkPointWidth.SelectedIndex]);
            settings.foregroundColor = Utils.ColorFromString(networkForegroundText.Text);
            settings.backgroundColor = Utils.ColorFromString(networkBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(networkBorderText.Text);
            settings.updateInterval = (int)networkInterval.Value;
            settings.maxBandwith = (int)networkMaxBandwidth.Value;

            Close();
        }

        // network
        private void networkForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(networkForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(networkForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            networkForegroundText.Text = Utils.ColorToString(color);
        }

        private void networkBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(networkBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(networkBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            networkBackgroundText.Text = Utils.ColorToString(color);
        }

        private void networkBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(networkBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(networkBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            networkBorderText.Text = Utils.ColorToString(color);
        }

        private void networkForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(networkForegroundText.Text);
            Color color2 = Color.FromArgb(networkForegroundOpacity.Value, color.R, color.G, color.B);
            networkForegroundText.Text = Utils.ColorToString(color2);
        }

        private void networkBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(networkBackgroundText.Text);
            Color color2 = Color.FromArgb(networkBackgroundOpacity.Value, color.R, color.G, color.B);
            networkBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void networkBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(networkBorderText.Text);
            Color color2 = Color.FromArgb(networkBorderOpacity.Value, color.R, color.G, color.B);
            networkBorderText.Text = Utils.ColorToString(color2);
        }
    }
}
