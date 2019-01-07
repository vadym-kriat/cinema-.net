using System;
using System.Windows.Forms;

namespace cinema_2
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            System.IO.Directory.CreateDirectory($"{Application.StartupPath}/tickets");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}