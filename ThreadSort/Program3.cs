using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program3 {
        [STAThread]
        static void Mainx() {
            Thread threadMain = new Thread(formStart1);
            threadMain.Start();
            Thread threadMain2 = new Thread(formStart2);
            threadMain2.Start();
        }
        static void formStart1() {
            //int[] pole1 = { 41, 62, 88, 12, 19, 1, 98, 28, 33, 75, 47, 22, 6, 69, 50 };
            int[] pole1 = new int[15]; // max prvku v poli
            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                pole1[i] = r.Next(100) + 1;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form3 f1 = new Form3(pole1);
            //f1.SetDesktopLocation(1000, 1000);
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            f1.ShowDialog();
        }
        static void formStart2() {
            //int[] pole2 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            int[] pole2 = new int[15]; // max prvku v poli
            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                pole2[i] = r.Next(100) + 1;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form3 f2 = new Form3(pole2);
            f2.SetDesktopLocation(1150, 370); // ojeb
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            f2.ShowDialog();

            // thread f2.sort start?
        }
    }
}
