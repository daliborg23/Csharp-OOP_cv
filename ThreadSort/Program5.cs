using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program5 {
        [STAThread]
        static void Main() {
            //Thread threadMain = new Thread(formStart1);
            //threadMain.Start();
            //Thread threadMain2 = new Thread(formStart2);
            //threadMain2.Start();
            //formStart1();
            //formStart2();
            //threadMain.Suspend();
            //threadMain2.Suspend();

            formStart3Both();


        }
        static void formStart1() {
            //int[] pole1 = { 41, 62, 88, 12, 19, 1, 98, 28, 33, 75, 47, 22, 6, 69, 50 };
            int[] pole1 = new int[15]; // max prvku v poli
            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                pole1[i] = r.Next(1,101);
            }
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form5 f1 = new Form5(pole1,"bubble");
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
                pole2[i] = r.Next(50,101);
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Form5 f2 = new Form5(pole2,"bubble");
            f2.SetDesktopLocation(1150, 370); // ojeb
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            f2.ShowDialog();

            // thread f2.sort start?
        }
        public class MultiFormContext : ApplicationContext {
            private int openForms;
            public MultiFormContext(params Form[] forms) {
                openForms = forms.Length;

                foreach (var form in forms) {
                    form.FormClosed += (s, args) =>
                    {
                        //When we have closed the last of the "starting" forms, 
                        //end the program.
                        if (Interlocked.Decrement(ref openForms) == 0)
                            ExitThread();
                    };
                    form.Show();
                }
            }
        }
        static void formStart3Both() {
            //int[] pole2 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            int[] pole1 = new int[15]; // max prvku v poli
            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                pole1[i] = r.Next(1, 101);
            }

            int[] pole2 = new int[15]; // max prvku v poli
            Random rnd = new Random();
            for (int i = 0; i < 15; i++) {
                pole2[i] = rnd.Next(1, 101);
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Form5 f2 = new Form5);
            //f2.SetDesktopLocation(1150, 370); // ojeb
            //Thread threadSort = new Thread(f2.sortProgressBars);
            //Application.Run(f2);
            //f2.ShowDialog();

            // thread f2.sort start?

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultiFormContext(new Form5(pole1, "bubble"), new Form5(pole2, "bubble")));
        }
    }
}
