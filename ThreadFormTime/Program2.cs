using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.implementation;

namespace ThreadFormTime {
    internal static class Program2 {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            Clock clock = new Clock();
            Thread t2 = new Thread(formStart);
            t2.Start();
        }
        public static void consoleStart() {
            // ?
        }
        public static void formStart() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Control_Panel());
            Clock clock = new Clock();
            Application.Run(new Control_Panel2(clock));
            //Application.Run(new Control_Panel2(new Clock()));
        }
    }
}
