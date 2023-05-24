using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.implementation;

namespace ThreadFormTime {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            //Clock clock = new Clock();
            //Thread t1 = new Thread(clock.loop);
            Thread t2 = new Thread(formStart);
            //t1.Start();
            t2.Start();
            //t2.Start();
            //clock.loop();
        }
        public static void consoleStart() {
        
        }
        public static void formStart() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Control_Panel());
        }
    }
}
