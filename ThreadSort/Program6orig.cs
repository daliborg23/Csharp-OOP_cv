using System;
using System.Threading;
using System.Windows.Forms;

namespace VlaknaTrideni {
    public class ThreadsManager {
        public int[] dataF;
        public Form6orig form;
        public int index;
        public ThreadsManager(Form6orig f6orig, int[] data, int index) {
            this.form = f6orig;
            this.dataF = data;
            this.index = index;
            //Thread t = new Thread();
        }
    }
    static class Program6orig {
        static int[] dataF;
        static Form6orig form;
        static int index;
        static void Main() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //int velikost = 15;
            //int[] data = new int[velikost];
            //Random nahodneCislo = new Random();
            //for (int x = 0; x < velikost; x++) {
            //    data[x] = nahodneCislo.Next(0, 101);
            //}
            int[] data = { 20,50,75,40,60,70,80,90 };

            //Form6orig f6orig1 = new Form6orig(data);
            //Form6orig f6orig2 = new Form6orig(data);
            //Form6orig f6orig3 = new Form6orig(data);
            //Thread t1 = new Thread(() => Application.Run(f6orig1));
            //Thread t2 = new Thread(() => Application.Run(f6orig2));
            //Thread t3 = new Thread(() => Application.Run(f6orig3));

            //t1.Start();t2.Start();t3.Start();

            //Thread.Sleep(1000);

            //Thread bubbleSortSimpleThread = new Thread(bubbleSortSimple); bubbleSortSimpleThread.Start();
            //Thread bubbleSortThread = new Thread(bubbleSort); bubbleSortThread.Start();
            //Thread bubbleSortOptimThread = new Thread(bubbleSortOptim); bubbleSortOptimThread.Start();

            //Thread.Sleep(1000);
            Form6orig f6orig = new Form6orig(data);
            form = f6orig;
            dataF = data;
            f6orig.Show();
            //bubbleSortSimple2(data, f6orig);
            //bubbleSortSimple();
            bubbleSort();
            //bubbleSortOptim();
            Thread.Sleep(2000);
        }

        private static void bubbleSort() {
            bool swapOccured = false;
            int pbTempVal;
            int indexLoop = 0;
            do {
                swapOccured = false;
                for (int j = 0; j < dataF.Length - 1; j++) {
                    if (dataF[j] > dataF[j + 1]) {
                        pbTempVal = dataF[j];
                        dataF[j] = dataF[j + 1];
                        dataF[j + 1] = pbTempVal;
                        swapOccured = true;
                    }
                    form.showData(j, j + 1, indexLoop);
                    Thread.Sleep(50);
                }
                indexLoop++;
                Thread.Sleep(500);
            } while (swapOccured);
        }
        private static void bubbleSortOptim() {
            int n = dataF.Length;
            bool swapOccurred = false;
            int pbTempVal;
            int indexLoop = 0;
            for (int i = 0; i < n - 1; i++) {
                swapOccurred = false;

                for (int j = 0; j < n - i - 1; j++) {
                    if (dataF[j] > dataF[j + 1]) {
                        pbTempVal = dataF[j];
                        dataF[j] = dataF[j + 1];
                        dataF[j + 1] = pbTempVal;
                        swapOccurred = true;
                    }
                    form.showData(j, j + 1, indexLoop);
                    Thread.Sleep(50);
                }

                if (!swapOccurred) {
                    // If no swaps occurred in the inner loop, the array is already sorted
                    break;
                }
                indexLoop++;
                Thread.Sleep(500);
            }
        }
        private static void bubbleSortSimple() {
            int pbTempVal;
            int indexLoop = 0;
            for (int i = 0; i < dataF.Length - 1; i++) {
                for (int j = 0; j < dataF.Length - 1; j++) {
                    if (dataF[j] > dataF[j + 1]) {
                        pbTempVal = dataF[j];
                        dataF[j] = dataF[j + 1];
                        dataF[j + 1] = pbTempVal;
                    }
                    indexLoop = i;
                    form.showData(j, j + 1, indexLoop);
                    Thread.Sleep(50);
                }
                Thread.Sleep(500);
            }
        }
        private static void bubbleSortSimple2(int[] data, Form6orig f6orig) {
            int pbTempVal;
            int indexLoop = 0;
            for (int i = 0; i < data.Length - 1; i++) {
                for (int j = 0; j < data.Length - 1; j++) {
                    if (data[j] > data[j + 1]) {
                        pbTempVal = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = pbTempVal;
                        indexLoop = i;
                        f6orig.showData(i,j, indexLoop);
                        Thread.Sleep(200);
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
