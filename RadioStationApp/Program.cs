using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStationApp
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RadioStation form = null;
            //bool createdNew = true;
            //using (Mutex mutex = new Mutex(true, "RadioStationApp", out createdNew))
            //{
            //    if (createdNew)
            //    {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    //form = new RadioStation();
                    Application.Run(new RadioStation());
            //    }
            //    else
            //    {
            //        //form.LoadArguments("-laRed");
            //        //Process current = Process.GetCurrentProcess();
            //        //foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            //        //{
            //        //    if (process.Id != current.Id)
            //        //    {
            //        //        //SetForegroundWindow(process.MainWindowHandle);
            //        //        form.LoadArguments();
            //        //        break;
            //        //    }
            //        //}
            //    }
            //}
        }
    }
}
