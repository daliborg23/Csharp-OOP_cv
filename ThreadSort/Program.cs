using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program {
        [STAThread]
        static void Main() {
            Thread threadMain = new Thread(formStart1);
            threadMain.Start();
            Thread threadMain2 = new Thread(formStart2);
            threadMain2.Start();
        }
        static void formStart1() {
            int[] pole1 = { 41, 62, 88, 12, 19, 1, 98, 28, 33, 75, 47, 22, 6, 69, 50 };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 f1 = new Form2(pole1);
            //f1.SetDesktopLocation(1000, 1000);
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            f1.ShowDialog();
        }
        static void formStart2() {
            int[] pole2 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 f2 = new Form2(pole2);
            f2.SetDesktopLocation(1150, 370);
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            f2.ShowDialog();
        }
    }
}
