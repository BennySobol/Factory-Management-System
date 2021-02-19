using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace DrMelomad
{
    static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "MyAppName";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)// app is already running, exit
                return;

            if (!Debugger.IsAttached)// if app is not runing from visual studio load database from %AppData%/Database diractory
                AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DrMelomad");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWin());
        }
    }
}
