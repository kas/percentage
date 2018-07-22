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

namespace DiskIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            // disk
            settings = CustomSettings.Instance;
            var availableDisks = CustomTrayIcon.GetDisks();
            availableDisks.Add("");
            availableDisks.Sort();
            diskPointWidth.SelectedIndex = diskPointWidth.FindStringExact(settings.pointWidth.ToString());
            diskName1.DataSource = new List<string>(availableDisks);
            diskName1.SelectedIndex = diskName1.FindStringExact(settings.name_disk1);
            diskColor1.Text = Utils.ColorToString(settings.foregroundColor_disk1);
            diskColor1Opacity.Value = settings.foregroundColor_disk1.A;
            diskName2.DataSource = new List<string>(availableDisks);
            diskName2.SelectedIndex = diskName2.FindStringExact(settings.name_disk2);
            diskColor2.Text = Utils.ColorToString(settings.foregroundColor_disk2);
            diskColor2Opacity.Value = settings.foregroundColor_disk2.A;
            diskName3.DataSource = new List<string>(availableDisks);
            diskName3.SelectedIndex = diskName3.FindStringExact(settings.name_disk3);
            diskColor3.Text = Utils.ColorToString(settings.foregroundColor_disk3);
            diskColor3Opacity.Value = settings.foregroundColor_disk3.A;
            diskBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            diskBackgroundOpacity.Value = settings.backgroundColor.A;
            diskBorderText.Text = Utils.ColorToString(settings.borderColor);
            diskBorderOpacity.Value = settings.borderColor.A;
            diskInterval.Value = settings.updateInterval;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // disk
            if (diskPointWidth.SelectedIndex >= 0)
                settings.pointWidth = Convert.ToInt32(diskPointWidth.Items[diskPointWidth.SelectedIndex]);
            if (diskName1.SelectedIndex >= 0)
                settings.name_disk1 = diskName1.Items[diskName1.SelectedIndex].ToString();
            if (diskName2.SelectedIndex >= 0)
                settings.name_disk2 = diskName2.Items[diskName2.SelectedIndex].ToString();
            if (diskName3.SelectedIndex >= 0)
                settings.name_disk3 = diskName3.Items[diskName3.SelectedIndex].ToString();
            settings.foregroundColor_disk1 = Utils.ColorFromString(diskColor1.Text);
            settings.foregroundColor_disk2 = Utils.ColorFromString(diskColor2.Text);
            settings.foregroundColor_disk3 = Utils.ColorFromString(diskColor3.Text);
            settings.backgroundColor = Utils.ColorFromString(diskBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(diskBorderText.Text);
            settings.updateInterval = (int)diskInterval.Value;

            Close();
        }

        private void diskColor1Button_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(diskColor1.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(diskColor1Opacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            diskColor1.Text = Utils.ColorToString(color);
        }

        private void diskColor2Button_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(diskColor2.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(diskColor2Opacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            diskColor2.Text = Utils.ColorToString(color);
        }

        private void diskColor3Button_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(diskColor3.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(diskColor3Opacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            diskColor3.Text = Utils.ColorToString(color);
        }

        private void diskBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(diskBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(diskBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            diskBackgroundText.Text = Utils.ColorToString(color);
        }

        private void diskBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(diskBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(diskBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            diskBorderText.Text = Utils.ColorToString(color);
        }

        private void diskColor1Opacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(diskColor1.Text);
            Color color2 = Color.FromArgb(diskColor1Opacity.Value, color.R, color.G, color.B);
            diskColor1.Text = Utils.ColorToString(color2);
        }

        private void diskColor2Opacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(diskColor2.Text);
            Color color2 = Color.FromArgb(diskColor2Opacity.Value, color.R, color.G, color.B);
            diskColor2.Text = Utils.ColorToString(color2);
        }

        private void diskColor3Opacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(diskColor3.Text);
            Color color2 = Color.FromArgb(diskColor3Opacity.Value, color.R, color.G, color.B);
            diskColor3.Text = Utils.ColorToString(color2);
        }

        private void diskBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(diskBackgroundText.Text);
            Color color2 = Color.FromArgb(diskBackgroundOpacity.Value, color.R, color.G, color.B);
            diskBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void diskBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(diskBorderText.Text);
            Color color2 = Color.FromArgb(diskBorderOpacity.Value, color.R, color.G, color.B);
            diskBorderText.Text = Utils.ColorToString(color2);
        }
    }
}
