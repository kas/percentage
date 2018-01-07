using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace percentage
{
    class TrayIcon
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool DestroyIcon(IntPtr handle);



        private NotifyIcon notifyIcon;
        private Timer updateTimer;

        public TrayIcon()
        {
            notifyIcon = new NotifyIcon();

            // initialize contextMenu
            notifyIcon.ContextMenu = new ContextMenu(new[]
            {
                new MenuItem("&Settings", menuSettings_Click),
                new MenuItem("E&xit", menuExit_Click),
                
            });

            notifyIcon.Visible = true;

            updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(UpdateIcon);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        const int SM_CXSMICON = 49;

        public int GetSmallIconSize()
        {
            return GetSystemMetrics(SM_CXSMICON);
        }

        public void DisableIcon()
        {
            updateTimer.Stop();
            notifyIcon.Visible = false;
        }

        public void EnableIcon()
        {
            updateTimer.Start();
            notifyIcon.Visible = true;
        }

        public void SetUpdateInterval(int interval)
        {
            updateTimer.Stop();
            updateTimer.Interval = interval;
            //updateTimer.Start();
        }

        public void ChangeIcon(Bitmap bitmap, string tooltip)
        {
            System.IntPtr intPtr = bitmap.GetHicon();
            try
            {
                using (Icon icon = Icon.FromHandle(intPtr))
                {
                    // tooltip should be changed along with icon (while icon not yet destroyed)
                    notifyIcon.Icon = icon;
                    notifyIcon.Text = tooltip;
                }
            }
            finally
            {
                DestroyIcon(intPtr);
            }
        }

        protected void DelayedIcon(int position)
        {
            // if app contains several icons windows shows it in next order: [1,2,3,4] -> [1,4,3,2]
            // so caclulate delay from wanted position
            // need change if increased maximum icons number
            int minimumDelay = 1000;
            int delay;
            if (position <= 1)
                delay = 1; // without delay (minimum allowed timer interval)
            else if (position == 2)
                delay = 3 * minimumDelay;
            else if (position == 3)
                delay = 2 * minimumDelay;
            else if (position == 4)
                delay = 1 * minimumDelay;
            else
                delay = 2 * minimumDelay; // too large number, mess it with last icon
            Timer timer = new Timer();
            timer.Interval = delay;
            timer.Tick += DelayedIconStart;
            timer.Start();
        }

        private void DelayedIconStart(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            updateTimer.Start();
            UpdateIcon(sender, e);
        }

        public virtual void UpdateIcon(object sender, EventArgs e)
        {
            // placeholder
            int iconSize = GetSmallIconSize();
            using (Bitmap bitmap = new Bitmap(iconSize, iconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.Red);
                    graphics.Save();
                    ChangeIcon(bitmap, "tooltip text");
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }

        protected virtual void menuSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            UpdateIcon(null, null);
        }
    }
}
