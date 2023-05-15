using System;
using System.Threading;
using System.Windows.Forms;

namespace VlaknaTrideni {
    static class Program6orig {
        static int[] dataF;
        static Form6orig form;
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            int velikost = 15;
            int[] data = new int[velikost];
            Random nahodneCislo = new Random();
            for (int x = 0; x < velikost; x++) {
                data[x] = nahodneCislo.Next(0, 101);
            }

            Form6orig f6orig = new Form6orig(data);
            form = f6orig;
            dataF = data;


            //Thread t1 = new Thread (f5orig.showData); t1.Start();
            f6orig.Show();
            //bubbleSortSimple(data, f6orig);
            bubbleSortSimple2();
        }

        private static void bubbleSortSimple(int[] data, Form6orig f6orig) {
            for (int i = 0; i < data.Length - 1; i++) {
                for (int j = 0; j < data.Length - 1 - i; j++) {
                    if (data[j] > data[j + 1]) {
                        int pbTempVal = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = pbTempVal;
                        f6orig.showData(i,j);
                        Thread.Sleep(200);
                    }
                }
                Thread.Sleep(1000);
            }
        }
        private static void bubbleSortSimple2() {
            for (int i = 0; i < dataF.Length - 1; i++) {
                for (int j = 0; j < dataF.Length - 1 - i; j++) {
                    if (dataF[j] > dataF[j + 1]) {
                        int pbTempVal = dataF[j];
                        dataF[j] = dataF[j + 1];
                        dataF[j + 1] = pbTempVal;
                        form.showData(j, j + 1);
                        Thread.Sleep(200);
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
