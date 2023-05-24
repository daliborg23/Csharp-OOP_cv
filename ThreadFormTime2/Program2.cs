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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Control_Panel2());
        }
    }
}
