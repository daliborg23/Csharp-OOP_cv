using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadFormTime {
    internal class Program3 {
        static void Main(string[] args) {
            // AsyncAwait.cs
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AsyncAwait());
        }
    }
}