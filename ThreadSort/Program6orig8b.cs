using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VlaknaTrideni {
    class Program6orig8b { // ThreadSort8b
        #region fields
        static int[] cisla1;
        static int[] cisla2;
        static int[] cisla3;
        static int[] cisla4;
        static Form6orig8b form1;
        static Form6orig8b form2;
        static Form6orig8b form3;
        static Form6orig8b form4;
        private static Thread t1;
        private static Thread t2;
        private static Thread t3;
        private static Thread t4;
        static EventWaitHandle t1WaitOne = new AutoResetEvent(false);
        static EventWaitHandle t2WaitOne = new AutoResetEvent(false);
        static EventWaitHandle t3WaitOne = new AutoResetEvent(false);
        static EventWaitHandle t4WaitOne = new AutoResetEvent(false);
        static EventWaitHandle t1Set = new AutoResetEvent(false);
        static EventWaitHandle t2Set = new AutoResetEvent(false);
        static EventWaitHandle t3Set = new AutoResetEvent(false);
        static EventWaitHandle t4Set = new AutoResetEvent(false);
        static bool tEnd1 = false;
        static bool tEnd2 = false;
        static bool tEnd3 = false;
        static bool tEnd4 = false;
        static int t1LoopIndexOut;
        static int t1LoopIndexIn;
        static int t1LoopIndex;       
        static int t1LoopIndexPlusOne;
        static int t2LoopIndexOut;
        static int t2LoopIndexIn;
        static int t2LoopIndex;
        static int t2LoopIndexPlusOne;
        static int t3LoopIndexOut;
        static int t3LoopIndexIn;
        static int t3LoopIndex;
        static int t3LoopIndexPlusOne;
        static int t4LoopIndexOut;
        static int t4LoopIndexIn;
        static int t4LoopIndex;
        static int t4LoopIndexPlusOne;
        #endregion

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

            #region forms
            Form6orig8b f6orig1 = new Form6orig8b(data1);
            int form1origLocX = 100;
            int form1origLocY = 100;
            form1 = f6orig1;
            cisla1 = data1;
            t1LoopIndexOut = 0;
            t1LoopIndexIn = 0;
            t1LoopIndex = 0;
            t1LoopIndexPlusOne = 0;
            f6orig1.Show();
            f6orig1.DesktopLocation = new Point(form1origLocX, form1origLocY);
            Form6orig8b f6orig2 = new Form6orig8b(data2);
            form2 = f6orig2;
            cisla2 = data2;
            t2LoopIndexOut = 0;
            t2LoopIndexIn = 0;
            t2LoopIndex = 0;
            t2LoopIndexPlusOne = 0;
            f6orig2.Show();
            form1origLocX += 320;
            f6orig2.Location = new Point(form1origLocX, form1origLocY);
            Form6orig8b f6orig3 = new Form6orig8b(data3);
            form3 = f6orig3;
            cisla3 = data3;
            t3LoopIndexOut = 0;
            t3LoopIndexIn = 0;
            t3LoopIndex = 0;
            t3LoopIndexPlusOne = 0;
            f6orig3.Show();
            form1origLocX += 320;
            f6orig3.Location = new Point(form1origLocX, form1origLocY);
            Form6orig8b f6orig4 = new Form6orig8b(data4);
            form4 = f6orig4;
            cisla4 = data4;
            t4LoopIndexOut = 0;
            t4LoopIndexIn = 0;
            t4LoopIndex = 0;
            t4LoopIndexPlusOne = 0;
            f6orig4.Show();
            form1origLocX += 320;
            f6orig4.Location = new Point(form1origLocX, form1origLocY);
            #endregion

            Thread.Sleep(1000);

            t1 = new Thread(bubbleSortSimple); t1.Start();
            t2 = new Thread(bubbleSort); t2.Start();
            t3 = new Thread(bubbleSortOptim); t3.Start();
            t4 = new Thread(SelectionSort);  t4.Start();

            while (!tEnd1 || !tEnd2 || !tEnd3 || !tEnd4) {
                form1.showData(t1LoopIndex, t1LoopIndexPlusOne, t1LoopIndexOut, t1LoopIndexIn, "bubbleSortSimple");
                form2.showData(t2LoopIndex, t2LoopIndexPlusOne, t2LoopIndexOut, t2LoopIndexIn, "bubbleSort");
                form3.showData(t3LoopIndex, t3LoopIndexPlusOne, t3LoopIndexOut, t3LoopIndexIn, "bubbleSortOptim");
                form4.showData(t4LoopIndex, t4LoopIndexPlusOne, t4LoopIndexOut, t4LoopIndexIn, "SelectionSort");
                if (!tEnd1) t1WaitOne.WaitOne();
                if (!tEnd2) t2WaitOne.WaitOne();
                if (!tEnd3) t3WaitOne.WaitOne();
                if (!tEnd4) t4WaitOne.WaitOne();
                t1Set.Set(); t2Set.Set(); t3Set.Set(); t4Set.Set();
                Thread.Sleep(250);
            }

            // System.Threading.ThreadStateException: 'Thread is not user-suspended; it cannot be resumed.'
            
            Thread.Sleep(10);
            DialogResult dialogResult = MessageBox.Show("Zavrit vse?", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK) { // Msgbox nevyskakuje do popredi
                Environment.Exit(0);
            }
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
                    Thread.Sleep(50);
                    indexLoopIn++;
                    t1LoopIndex = j;
                    t1LoopIndexPlusOne = j + 1;
                    t1LoopIndexOut = indexLoopOut;
                    t1LoopIndexIn = indexLoopIn;
                    t1WaitOne.Set();
                    t1Set.WaitOne();
                }
                indexLoopOut++;
            }
            tEnd1 = true;
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
                    Thread.Sleep(50);
                    indexLoopIn++;
                    t2LoopIndex = j;
                    t2LoopIndexPlusOne = j+1;
                    t2LoopIndexOut = indexLoopOut;
                    t2LoopIndexIn = indexLoopIn;
                    t2WaitOne.Set();
                    t2Set.WaitOne();
                }
                indexLoopOut++;
            } while (swapOccured);
            tEnd2 = true;
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
                    Thread.Sleep(50);
                    indexLoopIn++;
                    t3LoopIndex = j;
                    t3LoopIndexPlusOne = j + 1;
                    t3LoopIndexOut = indexLoopOut;
                    t3LoopIndexIn = indexLoopIn;
                    t3WaitOne.Set();
                    t3Set.WaitOne();
                }
                lastSwapIndex = currentSwapIndex;
                indexLoopOut++;
            } while (lastSwapIndex > 0);
            tEnd3 = true;
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
                    Thread.Sleep(50);
                    indexLoopIn++;
                    t4LoopIndex = j;
                    t4LoopIndexPlusOne = j + 1;
                    t4LoopIndexOut = indexLoopOut;
                    t4LoopIndexIn = indexLoopIn;
                    t4WaitOne.Set();
                    t4Set.WaitOne();
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
            }
            tEnd4 = true;
        }
    }
}
