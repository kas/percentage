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
        SettingsBattery settingsBattery;
        SettingsCpu settingsCpu;
        SettingsRam settingsRam;
        SettingsNetwork settingsNetwork;
        SettingsDisk settingsDisk;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            // battery
            settingsBattery = SettingsBattery.Instance;
            batteryEnabled.Checked = settingsBattery.enabled > 0;
            batteryPosition.SelectedIndex = batteryPosition.FindStringExact(settingsBattery.position.ToString());
            batteryFontText.Text = settingsBattery.fontName + ", " + settingsBattery.fontSize;
            batteryFontDialog.Font = new Font(settingsBattery.fontName, settingsBattery.fontSize);
            batteryScaling.Checked = settingsBattery.scaling > 0;
            batteryForegroundText.Text = Utils.ColorToString(settingsBattery.foregroundColor);
            batteryForegroundOpacity.Value = settingsBattery.foregroundColor.A;
            batteryBackgroundText.Text = Utils.ColorToString(settingsBattery.backgroundColor);
            batteryBackgroundOpacity.Value = settingsBattery.backgroundColor.A;
            batteryBorderText.Text = Utils.ColorToString(settingsBattery.borderColor);
            batteryBorderOpacity.Value = settingsBattery.borderColor.A;
            batteryInterval.Value = settingsBattery.updateInterval;

            // cpu
            settingsCpu = SettingsCpu.Instance;
            cpuEnabled.Checked = settingsCpu.enabled > 0;
            cpuPosition.SelectedIndex = cpuPosition.FindStringExact(settingsCpu.position.ToString());
            cpuPointWidth.SelectedIndex = cpuPointWidth.FindStringExact(settingsCpu.pointWidth.ToString());
            cpuForegroundText.Text = Utils.ColorToString(settingsCpu.foregroundColor);
            cpuForegroundOpacity.Value = settingsCpu.foregroundColor.A;
            cpuBackgroundText.Text = Utils.ColorToString(settingsCpu.backgroundColor);
            cpuBackgroundOpacity.Value = settingsCpu.backgroundColor.A;
            cpuBorderText.Text = Utils.ColorToString(settingsCpu.borderColor);
            cpuBorderOpacity.Value = settingsCpu.borderColor.A;
            cpuInterval.Value = settingsCpu.updateInterval;

            // ram
            settingsRam = SettingsRam.Instance;
            ramEnabled.Checked = settingsRam.enabled > 0;
            ramPosition.SelectedIndex = ramPosition.FindStringExact(settingsRam.position.ToString());
            ramPointWidth.SelectedIndex = ramPointWidth.FindStringExact(settingsRam.pointWidth.ToString());
            ramForegroundText.Text = Utils.ColorToString(settingsRam.foregroundColor);
            ramForegroundOpacity.Value = settingsRam.foregroundColor.A;
            ramBackgroundText.Text = Utils.ColorToString(settingsRam.backgroundColor);
            ramBackgroundOpacity.Value = settingsRam.backgroundColor.A;
            ramBorderText.Text = Utils.ColorToString(settingsRam.borderColor);
            ramBorderOpacity.Value = settingsRam.borderColor.A;
            ramInterval.Value = settingsRam.updateInterval;

            // network
            settingsNetwork = SettingsNetwork.Instance;
            networkEnabled.Checked = settingsNetwork.enabled > 0;
            networkPosition.SelectedIndex = networkPosition.FindStringExact(settingsNetwork.position.ToString());
            networkPointWidth.SelectedIndex = networkPointWidth.FindStringExact(settingsNetwork.pointWidth.ToString());
            networkForegroundText.Text = Utils.ColorToString(settingsNetwork.foregroundColor);
            networkForegroundOpacity.Value = settingsNetwork.foregroundColor.A;
            networkBackgroundText.Text = Utils.ColorToString(settingsNetwork.backgroundColor);
            networkBackgroundOpacity.Value = settingsNetwork.backgroundColor.A;
            networkBorderText.Text = Utils.ColorToString(settingsNetwork.borderColor);
            networkBorderOpacity.Value = settingsNetwork.borderColor.A;
            networkInterval.Value = settingsNetwork.updateInterval;
            networkMaxBandwidth.Value = settingsNetwork.maxBandwith;

            // disk
            settingsDisk = SettingsDisk.Instance;
            var availableDisks = DiskIcon.GetDisks();
            availableDisks.Add("");
            availableDisks.Sort();
            diskEnabled.Checked = settingsDisk.enabled > 0;
            diskPosition.SelectedIndex = diskPosition.FindStringExact(settingsDisk.position.ToString());
            diskPointWidth.SelectedIndex = diskPointWidth.FindStringExact(settingsDisk.pointWidth.ToString());
            diskName1.DataSource = new List<string>(availableDisks);
            diskName1.SelectedIndex = diskName1.FindStringExact(settingsDisk.name_disk1);
            diskColor1.Text = Utils.ColorToString(settingsDisk.foregroundColor_disk1);
            diskColor1Opacity.Value = settingsDisk.foregroundColor_disk1.A;
            diskName2.DataSource = new List<string>(availableDisks);
            diskName2.SelectedIndex = diskName2.FindStringExact(settingsDisk.name_disk2);
            diskColor2.Text = Utils.ColorToString(settingsDisk.foregroundColor_disk2);
            diskColor2Opacity.Value = settingsDisk.foregroundColor_disk2.A;
            diskName3.DataSource = new List<string>(availableDisks);
            diskName3.SelectedIndex = diskName3.FindStringExact(settingsDisk.name_disk3);
            diskColor3.Text = Utils.ColorToString(settingsDisk.foregroundColor_disk3);
            diskColor3Opacity.Value = settingsDisk.foregroundColor_disk3.A;
            diskBackgroundText.Text = Utils.ColorToString(settingsDisk.backgroundColor);
            diskBackgroundOpacity.Value = settingsDisk.backgroundColor.A;
            diskBorderText.Text = Utils.ColorToString(settingsDisk.borderColor);
            diskBorderOpacity.Value = settingsDisk.borderColor.A;
            diskInterval.Value = settingsDisk.updateInterval;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // battery
            settingsBattery.enabled = Convert.ToInt32(batteryEnabled.Checked);
            if (batteryPosition.SelectedIndex >= 0)
                settingsBattery.position = Convert.ToInt32(batteryPosition.Items[batteryPosition.SelectedIndex]);
            settingsBattery.fontName = batteryFontDialog.Font.Name;
            settingsBattery.fontSize = Convert.ToInt32(batteryFontDialog.Font.Size);
            settingsBattery.scaling = Convert.ToInt32(batteryScaling.Checked);
            settingsBattery.foregroundColor = Utils.ColorFromString(batteryForegroundText.Text);
            settingsBattery.backgroundColor = Utils.ColorFromString(batteryBackgroundText.Text);
            settingsBattery.borderColor = Utils.ColorFromString(batteryBorderText.Text);
            settingsBattery.updateInterval = (int)batteryInterval.Value;

            // cpu
            settingsCpu.enabled = Convert.ToInt32(cpuEnabled.Checked);
            if (cpuPosition.SelectedIndex >= 0)
                settingsCpu.position = Convert.ToInt32(cpuPosition.Items[cpuPosition.SelectedIndex]);
            if (cpuPointWidth.SelectedIndex >= 0)
                settingsCpu.pointWidth = Convert.ToInt32(cpuPointWidth.Items[cpuPointWidth.SelectedIndex]);
            settingsCpu.foregroundColor = Utils.ColorFromString(cpuForegroundText.Text);
            settingsCpu.backgroundColor = Utils.ColorFromString(cpuBackgroundText.Text);
            settingsCpu.borderColor = Utils.ColorFromString(cpuBorderText.Text);
            settingsCpu.updateInterval = (int)cpuInterval.Value;

            // ram
            settingsRam.enabled = Convert.ToInt32(ramEnabled.Checked);
            if (ramPosition.SelectedIndex >= 0)
                settingsRam.position = Convert.ToInt32(ramPosition.Items[ramPosition.SelectedIndex]);
            if (ramPointWidth.SelectedIndex >= 0)
                settingsRam.pointWidth = Convert.ToInt32(ramPointWidth.Items[ramPointWidth.SelectedIndex]);
            settingsRam.foregroundColor = Utils.ColorFromString(ramForegroundText.Text);
            settingsRam.backgroundColor = Utils.ColorFromString(ramBackgroundText.Text);
            settingsRam.borderColor = Utils.ColorFromString(ramBorderText.Text);
            settingsRam.updateInterval = (int)ramInterval.Value;

            // network
            settingsNetwork.enabled = Convert.ToInt32(networkEnabled.Checked);
            if (networkPosition.SelectedIndex >= 0)
                settingsNetwork.position = Convert.ToInt32(networkPosition.Items[networkPosition.SelectedIndex]);
            if (networkPointWidth.SelectedIndex >= 0)
                settingsNetwork.pointWidth = Convert.ToInt32(networkPointWidth.Items[networkPointWidth.SelectedIndex]);
            settingsNetwork.foregroundColor = Utils.ColorFromString(networkForegroundText.Text);
            settingsNetwork.backgroundColor = Utils.ColorFromString(networkBackgroundText.Text);
            settingsNetwork.borderColor = Utils.ColorFromString(networkBorderText.Text);
            settingsNetwork.updateInterval = (int)networkInterval.Value;
            settingsNetwork.maxBandwith = (int)networkMaxBandwidth.Value;

            // disk
            settingsDisk.enabled = Convert.ToInt32(diskEnabled.Checked);
            if (diskPosition.SelectedIndex >= 0)
                settingsDisk.position = Convert.ToInt32(diskPosition.Items[diskPosition.SelectedIndex]);
            if (diskPointWidth.SelectedIndex >= 0)
                settingsDisk.pointWidth = Convert.ToInt32(diskPointWidth.Items[diskPointWidth.SelectedIndex]);
            if (diskName1.SelectedIndex >= 0)
                settingsDisk.name_disk1 = diskName1.Items[diskName1.SelectedIndex].ToString();
            if (diskName2.SelectedIndex >= 0)
                settingsDisk.name_disk2 = diskName2.Items[diskName2.SelectedIndex].ToString();
            if (diskName3.SelectedIndex >= 0)
                settingsDisk.name_disk3 = diskName3.Items[diskName3.SelectedIndex].ToString();
            settingsDisk.foregroundColor_disk1 = Utils.ColorFromString(diskColor1.Text);
            settingsDisk.foregroundColor_disk2 = Utils.ColorFromString(diskColor2.Text);
            settingsDisk.foregroundColor_disk3 = Utils.ColorFromString(diskColor3.Text);
            settingsDisk.backgroundColor = Utils.ColorFromString(diskBackgroundText.Text);
            settingsDisk.borderColor = Utils.ColorFromString(diskBorderText.Text);
            settingsDisk.updateInterval = (int)diskInterval.Value;

            Close();
        }

        // battery
        private void batteryFontButton_Click(object sender, EventArgs e)
        {
            Font font = new Font(settingsBattery.fontName, settingsBattery.fontSize);
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

        // cpu
        private void cpuForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(cpuForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(cpuForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            cpuForegroundText.Text = Utils.ColorToString(color);
        }

        private void cpuBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(cpuBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(cpuBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            cpuBackgroundText.Text = Utils.ColorToString(color);
        }

        private void cpuBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(cpuBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(cpuBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            cpuBorderText.Text = Utils.ColorToString(color);
        }

        private void cpuForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(cpuForegroundText.Text);
            Color color2 = Color.FromArgb(cpuForegroundOpacity.Value, color.R, color.G, color.B);
            cpuForegroundText.Text = Utils.ColorToString(color2);
        }

        private void cpuBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(cpuBackgroundText.Text);
            Color color2 = Color.FromArgb(cpuBackgroundOpacity.Value, color.R, color.G, color.B);
            cpuBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void cpuBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(cpuBorderText.Text);
            Color color2 = Color.FromArgb(cpuBorderOpacity.Value, color.R, color.G, color.B);
            cpuBorderText.Text = Utils.ColorToString(color2);
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
