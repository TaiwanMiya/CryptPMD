using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Crypto
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsOpen())
            {
                MessageBox.Show("應用程式已開啟!\n請勿重複開啟程序!", "已開啟的應用", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            Application.Run(new Crypto());
        }

        static bool IsOpen()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                return true;
            else
                return false;
        }
    }
}
