using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    public class Program5 {
        [STAThread]
        static void Main() {
            //int[] poleCisel = new int[15];
            //Random r = new Random();
            //for (int i = 0; i < 15; i++) {
            //    poleCisel[i] = r.Next(1, 101);
            //}
            int[] poleCisel1 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            int[] poleCisel2 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            int[] poleCisel3 = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };

            Form5 f1 = new Form5(poleCisel1, "BubbleSortSimple"); 
            Form5 f2 = new Form5(poleCisel2, "BubbleSortOptim");
            Form5 f3 = new Form5(poleCisel3, "SelectionSort");

            Thread t1 = new Thread(() => {
                Application.Run(f1);
            });

            Thread t2 = new Thread(() => {
                Application.Run(f2);
            });

            Thread t3 = new Thread(() => {
                Application.Run(f3);
            });

            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(1000); // Add a delay to ensure both forms have started before continuing

            Thread sortThread1 = new Thread(f1.PBBubbleSort);
            Thread sortThread2 = new Thread(f2.PBBubbleSortOptim);
            Thread sortThread3 = new Thread(f3.SelectionSort);

            sortThread1.Start();
            sortThread2.Start();
            sortThread3.Start();

            Thread.Sleep(10000);
            DialogResult dialogResult = MessageBox.Show("Zavrit vse?", "Konec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK) { // Msgbox nevyskakuje do popredi
                Environment.Exit(0);
            }
        }
    }
}