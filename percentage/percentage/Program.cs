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

            TrayIcon trayIcon = new BatteryIcon();  // 1
            TrayIcon trayIcon4 = new NetworkIcon(); // 4
            TrayIcon trayIcon3 = new RamIcon();     // 3
            TrayIcon trayIcon2 = new CpuIcon();     // 2

            Application.Run();
        }
    }
}
