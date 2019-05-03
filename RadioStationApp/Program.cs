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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*====================================================
             * 
             * Add codes here to set the Winform as Singleton
             * 
             * ==================================================*/
            bool mutexIsAvailable = false;

            Mutex mutex = null;

            try
            {
                mutex = new Mutex(true, "RadioStationApp");
                mutexIsAvailable = mutex.WaitOne(1, false); // Wait only 1 ms
            }
            catch (AbandonedMutexException)
            {
                // don't worry about the abandonment; 
                // the mutex only guards app instantiation
                mutexIsAvailable = true;
            }

            if (mutexIsAvailable)
            {
                try
                {
                    Application.Run(new RadioStation());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
                Application.OpenForms["RadioStationApp"].BringToFront();

            //Application.Run(new SampleOfSingletonWinForm());

            //bool createdNew = true;
            //int currentProcess = Process.GetCurrentProcess().Id;

            //using (Mutex mutex = new Mutex(true, "RadioStationApp", out createdNew))
            //{
            //    if (createdNew)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        MessageBox.Show(currentProcess.ToString());
            //        Application.Run(new RadioStation());
            //    }
            //    else
            //    {
            //        if(currentProcess > 0)
            //        {
            //            //SetForegroundWindow(currentProcess.MainWindowHandle);
            //            MessageBox.Show(Process.GetProcessById(currentProcess).Id.ToString());
            //        }

            //        //Process current = Process.GetCurrentProcess();
            //        //foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            //        //{
            //        //    if (process.Id != current.Id)
            //        //    {
            //        //        SetForegroundWindow(process.MainWindowHandle);
            //        //        break;
            //        //    }
            //        //}
            //    }
            //}
        }

        //public static Process RunningInstance()
        //{
        //    Process current = Process.GetCurrentProcess();
        //    Process[] processes = Process.GetProcessesByName(current.ProcessName);

        //    //Loop through the running processes in with the same name 
        //    foreach (Process process in processes)
        //    {
        //        //Ignore the current process 
        //        if (process.Id != current.Id)
        //        {
        //            //Make sure that the process is running from the exe file. 
        //            if (System.Reflection.Assembly.GetExecutingAssembly().Location.
        //                 Replace("/", "\\") == current.MainModule.FileName)

        //            {
        //                //Return the other process instance.  
        //                return process;

        //            }
        //        }
        //    }
        //    //No other instance was found, return null.  
        //    return null;
        //}
    }
}
