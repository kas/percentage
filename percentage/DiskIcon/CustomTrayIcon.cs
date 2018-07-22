using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using IconLibrary;

namespace DiskIcon
{
    class CustomTrayIcon: TrayIcon
    {
        private CustomSettings settings;
        PerformanceCounter disk1Counter;
        PerformanceCounter disk2Counter;
        PerformanceCounter disk3Counter;
        List<float> measurents_disk1 = new List<float>();
        List<float> measurents_disk2 = new List<float>();
        List<float> measurents_disk3 = new List<float>();

        public CustomTrayIcon()
        {
            settings = CustomSettings.Instance;

            disk1Counter = new PerformanceCounter("PhysicalDisk", "% Idle Time", settings.name_disk1);
            disk2Counter = new PerformanceCounter("PhysicalDisk", "% Idle Time", settings.name_disk2);
            disk3Counter = new PerformanceCounter("PhysicalDisk", "% Idle Time", settings.name_disk3);

            SetUpdateInterval(settings.updateInterval);
            EnableIcon();
        }

        public override void menuSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            // immediatly see changes (works only on current icon)
            UpdateIcon(null, null);
        }

        public static List<string> GetDisks()
        {
            var result = new List<string>();
            PerformanceCounterCategory pcg = new PerformanceCounterCategory("PhysicalDisk");
            foreach (string diskName in pcg.GetInstanceNames())
                result.Add(diskName);
            return result;
        }

        public float GetDiskUsage(PerformanceCounter counter)
        {
            return Math.Max(100 - counter.NextValue(), 0);
        }

        private string BeautifyDiskName(string name)
        {
            if (name == "_Total")
            {
                return "Total";
            }
            if (name.Length >= 2 && Char.IsDigit(name[0]) && name[1] == ' ')
            {
                return "Disk " + name[0].ToString();
            }
            return name;
        }

        public override void UpdateIcon(object sender, EventArgs e)
        {
            int iconSize = GetSmallIconSize();
            const int borderWidth = 1;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;
            int pointWidth = settings.pointWidth;

            using (Bitmap bitmap = new Bitmap(iconSize, iconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);
                    string tooltip = "Disks";
                    if (settings.name_disk1.Length > 0)
                    {
                        try
                        {
                            float newValue = GetDiskUsage(disk1Counter);
                            Console.WriteLine("disk1:" + newValue.ToString());
                            measurents_disk1.Add(newValue);
                            for (int i = measurents_disk1.Count - 1; i >= 0; i--)
                            {
                                float value = measurents_disk1[i];
                                var pos = bitmap.Width - (measurents_disk1.Count - 1 - i) * pointWidth;
                                graphics.DrawLine(new Pen(settings.foregroundColor_disk1, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                            }
                            tooltip += String.Format("\n{0}: {1:F0}%", BeautifyDiskName(settings.name_disk1), newValue);
                            // clean oldest
                            if (measurents_disk1.Count > bitmap.Width / pointWidth)
                                measurents_disk1.RemoveAt(0);
                        }
                        catch (System.InvalidOperationException)
                        {

                        }

                    }
                    if (settings.name_disk2.Length > 0)
                    {
                        try
                        {
                            float newValue = GetDiskUsage(disk2Counter);
                            Console.WriteLine("disk2:" + newValue.ToString());
                            measurents_disk2.Add(newValue);
                            for (int i = measurents_disk2.Count - 1; i >= 0; i--)
                            {
                                float value = measurents_disk2[i];
                                var pos = bitmap.Width - (measurents_disk2.Count - 1 - i) * pointWidth;
                                graphics.DrawLine(new Pen(settings.foregroundColor_disk3, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                            }
                            tooltip += String.Format("\n{0}: {1:F0}%", BeautifyDiskName(settings.name_disk2), newValue);
                            // clean oldest
                            if (measurents_disk2.Count > bitmap.Width / pointWidth)
                                measurents_disk2.RemoveAt(0);
                        }
                        catch (System.InvalidOperationException)
                        {

                        }
                    }
                    if (settings.name_disk3.Length > 0)
                    {
                        try
                        {
                            float newValue = GetDiskUsage(disk3Counter);
                            Console.WriteLine("disk3:" + newValue.ToString());
                            measurents_disk3.Add(newValue);
                            for (int i = measurents_disk3.Count - 1; i >= 0; i--)
                            {
                                float value = measurents_disk3[i];
                                var pos = bitmap.Width - (measurents_disk3.Count - 1 - i) * pointWidth;
                                graphics.DrawLine(new Pen(settings.foregroundColor_disk3, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                            }
                            tooltip += String.Format("\n{0}: {1:F0}%", BeautifyDiskName(settings.name_disk3), newValue);
                            // clean oldest
                            if (measurents_disk3.Count > bitmap.Width / pointWidth)
                                measurents_disk3.RemoveAt(0);
                        }
                        catch (System.InvalidOperationException)
                        {

                        }
                    }
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)bitmap.Width - borderWidth, (int)bitmap.Height - borderWidth);
                    graphics.Save();
                    ChangeIcon(bitmap, tooltip);
                }
            }
        }
    }
}
