using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VlaknaTrideni {
    class Program6orig { // ThreadSort6-8a
        static int[] cisla1;
        static int[] cisla2;
        static int[] cisla3;
        static int[] cisla4;
        static Form6orig form1;
        static Form6orig form2;
        static Form6orig form3;
        static Form6orig form4;
        private static Thread t1;
        private static Thread t2;
        private static Thread t3;
        private static Thread t4;
        [STAThread]
        static void Mainx() {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            int velikost = 15;
            int[] data = new int[velikost];
            Random nahodneCislo = new Random();
            for (int x = 0; x < velikost; x++) {
                data[x] = nahodneCislo.Next(0, 101);
            }
            //int[] data1 = new int[velikost];
            //int[] data2 = new int[velikost];
            //int[] data3 = new int[velikost];
            //Array.Copy(data, data1, data.Length);
            //Array.Copy(data, data2, data.Length);
            //Array.Copy(data, data3, data.Length);

            //int[] data1 = { 20, 50, 75, 40, 60, 70, 80, 90 };
            //int[] data2 = { 20, 50, 75, 40, 60, 70, 80, 90 };
            //int[] data3 = { 20, 50, 75, 40, 60, 70, 80, 90 };

            int[] data1 = { 88, 21, 59, 35, 45, 27, 79, 10, 58, 26, 13, 71, 91, 23, 86 };
            int[] data2 = { 88, 21, 59, 35, 45, 27, 79, 10, 58, 26, 13, 71, 91, 23, 86 };
            int[] data3 = { 88, 21, 59, 35, 45, 27, 79, 10, 58, 26, 13, 71, 91, 23, 86 };
            int[] data4 = { 88, 21, 59, 35, 45, 27, 79, 10, 58, 26, 13, 71, 91, 23, 86 };

            Thread.Sleep(1000);

            Form6orig f6orig1 = new Form6orig(data1);
            int form1origLocX = 100;
            int form1origLocY = 100;
            form1 = f6orig1;
            cisla1 = data1;
            f6orig1.Show();
            f6orig1.DesktopLocation = new Point(form1origLocX, form1origLocY);
            Form6orig f6orig2 = new Form6orig(data2);
            form2 = f6orig2;
            cisla2 = data2;
            f6orig2.Show();
            form1origLocX += 320;
            f6orig2.Location = new Point(form1origLocX, form1origLocY);
            Form6orig f6orig3 = new Form6orig(data3);
            form3 = f6orig3;
            cisla3 = data3;
            f6orig3.Show();
            form1origLocX += 320;
            f6orig3.Location = new Point(form1origLocX, form1origLocY);
            Form6orig f6orig4 = new Form6orig(data4);
            form4 = f6orig4;
            cisla4 = data4;
            f6orig4.Show();
            form1origLocX += 320;
            f6orig4.Location = new Point(form1origLocX, form1origLocY);

            Thread.Sleep(2000);

            t1 = new Thread(bubbleSortSimple);
            t2 = new Thread(bubbleSort);
            t3 = new Thread(bubbleSortOptim);
            t4 = new Thread(SelectionSort);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join(); // ?
            t2.Join();
            t3.Join();
            t4.Join();
            Thread.Sleep(10000);
        }
        public static void bubbleSortSimple() {
            string name = "bubbleSortSimple";
            int pbTempVal;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            for (int i = 0; i < cisla1.Length - 1; i++) {
                for (int j = 0; j < cisla1.Length - 1; j++) {
                    if (cisla1[j] > cisla1[j + 1]) {
                        pbTempVal = cisla1[j];
                        cisla1[j] = cisla1[j + 1];
                        cisla1[j + 1] = pbTempVal;
                    }
                    indexLoopIn++;
                    form1.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
                    Thread.Sleep(50);
                }
                indexLoopOut++;
                Thread.Sleep(500);
            }
            Thread.Sleep(1000);
        }
        private static void bubbleSort() {
            string name = "bubbleSort";
            bool swapOccured;
            int pbTempVal;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            do {
                swapOccured = false;
                for (int j = 0; j < cisla2.Length - 1; j++) {
                    if (cisla2[j] > cisla2[j + 1]) {
                        pbTempVal = cisla2[j];
                        cisla2[j] = cisla2[j + 1];
                        cisla2[j + 1] = pbTempVal;
                        swapOccured = true;
                    }
                    indexLoopIn++;
                    form2.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
                    Thread.Sleep(50);
                }
                indexLoopOut++;
                Thread.Sleep(500);
            } while (swapOccured);
        }
        private static void bubbleSortOptim() { // 12904, 12749, 12751, 12760, 12684 // po upravach pomalejsi
            string name = "bubbleSortOptim";
            int lastSwapIndex = cisla3.Length;
            int currentSwapIndex;
            int pbTempVal;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            do {
                currentSwapIndex = 0;
                for (int j = 0; j < lastSwapIndex - 1; j++) {
                    if (cisla3[j] > cisla3[j + 1]) {
                        pbTempVal = cisla3[j];
                        cisla3[j] = cisla3[j + 1];
                        cisla3[j + 1] = pbTempVal;
                        currentSwapIndex = j + 1;
                    }
                    indexLoopIn++;
                    form3.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
                    Thread.Sleep(50);
                }
                lastSwapIndex = currentSwapIndex;
                indexLoopOut++;
                Thread.Sleep(500);
            } while (lastSwapIndex > 0);
        }
        //private static void bubbleSortOptim() { // 13225 13258 13182 13179 13308 13180
        //    string name = "bubbleSortOptim";
        //    int n = cisla3.Length;
        //    int pbTempVal;
        //    int indexLoopOut = 0;
        //    int indexLoopIn = 0;
        //    bool swapOccurred;

        //    for (int i = 0; i < n - 1; i++) {
        //        swapOccurred = false;
        //        for (int j = 0; j < n - i - 1; j++) {
        //            if (cisla3[j] > cisla3[j + 1]) {
        //                pbTempVal = cisla3[j];
        //                cisla3[j] = cisla3[j + 1];
        //                cisla3[j + 1] = pbTempVal;
        //                swapOccurred = true;
        //                indexLoopIn++;
        //            }
        //            form3.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
        //            Thread.Sleep(50);
        //        }

        //        if (!swapOccurred) {
        //            // If no swaps occurred in the inner loop, the array is already sorted
        //            break;
        //        }
        //        indexLoopOut++;
        //        Thread.Sleep(500);
        //    }
        //}
        private static void SelectionSort() { //
            string name = "SelectionSort";
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            if (cisla4.Length <= 1)
                return;

            var arrayLength = cisla4.Length;

            for (int i = 0; i < arrayLength - 1; i++) {
                int minIndex = i;

                for (int j = i + 1; j < arrayLength; j++) {
                    if (cisla4[j] < cisla4[minIndex]) {
                        minIndex = j;
                    }
                    indexLoopIn++;
                    form4.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
                    Thread.Sleep(50);
                }

                if (minIndex != i) {
                    SwapInts(cisla4,i, minIndex);
                }
                void SwapInts(int[] array, int index ,int min) {
                    // Swaps elements in an array.
                    int temp = array[index];
                    array[index] = array[min];
                    array[min] = temp;
                }
                indexLoopOut++;
                Thread.Sleep(500);
            }
        }
    }
}
