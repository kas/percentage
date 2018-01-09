using System;
using System.Windows.Forms;

namespace percentage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TrayIcon trayIcon1 = new BatteryIcon();
            TrayIcon trayIcon2 = new NetworkIcon();
            TrayIcon trayIcon3 = new RamIcon();
            TrayIcon trayIcon4 = new CpuIcon();
            TrayIcon trayIcon5 = new DiskIcon();

            Application.Run();
        }
    }
}
