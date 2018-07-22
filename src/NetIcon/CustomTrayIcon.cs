﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using IconLibrary;

namespace NetIcon
{
    class CustomTrayIcon: TrayIcon
    {
        private CustomSettings settings;
        List<float> measurents = new List<float>();
        List<PerformanceCounter> counters = new List<PerformanceCounter>();

        public CustomTrayIcon()
        {
            settings = CustomSettings.Instance;

            UpdateNICList();

            // periodical check for new network interfaces
            Timer checkNICTimer = new Timer();
            checkNICTimer.Interval = 60 * 1000;
            checkNICTimer.Tick += CheckNICList;
            checkNICTimer.Start();

            SetUpdateInterval(settings.updateInterval);
            EnableIcon();
        }

        public override void menuSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            // immediatly see changes (works only on current icon)
            UpdateIcon(null, null);
        }

        private void CheckNICList(object sender, EventArgs e)
        {
            PerformanceCounterCategory pcg = new PerformanceCounterCategory("Network Adapter");
            if (counters.Count != pcg.GetInstanceNames().Length)
            {
                UpdateNICList();
            }
        }

        private void UpdateNICList()
        {
            counters.Clear();
            PerformanceCounterCategory pcg = new PerformanceCounterCategory("Network Adapter");
            foreach (var networkInterface in pcg.GetInstanceNames())
            {
                var counter = new PerformanceCounter("Network Adapter", "Bytes Total/sec", networkInterface);
                counters.Add(counter);
            }
        }

        public float GetNetworkLoad()
        {
            float totalBytes = 0;
            foreach (var counter in counters)
            {
                try
                {
                    totalBytes += counter.NextValue();
                }
                catch (System.InvalidOperationException)
                {
                    // ignore disappeared network interfaces
                }

            }
            return totalBytes;
        }

        public override void UpdateIcon(object sender, EventArgs e)
        {
            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;

            int pointWidth = settings.pointWidth;
            int bandwidthMax = settings.maxBandwith;

            int iconSize = GetSmallIconSize();
            using (Bitmap bitmap = new Bitmap(iconSize, iconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);

                    float newValue = GetNetworkLoad();
                    measurents.Add(100 * newValue / bandwidthMax);
                    if (measurents.Count > bitmap.Width / pointWidth)
                    {
                        measurents.RemoveAt(0);
                    }

                    for (int i = measurents.Count - 1; i >= 0; i--)
                    {
                        float value = measurents[i];
                        var pos = bitmap.Width - (measurents.Count - 1 - i) * pointWidth;
                        graphics.DrawLine(new Pen(foregroundColor, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                    }

                    int borderWidth = 1;
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)bitmap.Width - borderWidth, (int)bitmap.Height - borderWidth);

                    graphics.Save();
                    float averageBandwith = measurents.Average() * bandwidthMax / 100;
                    string tooltip = String.Format("Network ({0} adapters): {1:F0} Kbit/s\nAvg: {2:F0} Kbit/s", counters.Count, newValue / 1024 * 8, averageBandwith / 1024 * 8);
                    ChangeIcon(bitmap, tooltip);
                }
            }
        }
    }
}
