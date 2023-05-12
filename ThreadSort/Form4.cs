using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    public class Form4 : Form {
        int pocetFormularu;
        int[] poleCisel;
        public Form4(int[] arrayInput) {
            this.poleCisel = arrayInput;
            int rowWidth = 311;
            int rowHeight = 12;
            int spaceBetweenRows = 13;
            pocetFormularu = 0;
            //
            // ProgressBars
            //
            //Thread t1 = new Thread(sortProgressBars); t1.Start();
            this.progressPole1 = new ProgressBar[arrayInput.Length];
            for (int ii = 0; ii <= arrayInput.Length - 1; ii++) {
                progressPole1[ii] = new ProgressBar();
            }
            int i = 0;
            int pointX = 13;
            int pointY = 13;

            foreach (ProgressBar pb in progressPole1) {
                pb.Location = new Point(pointX, pointY);
                pb.Name = "ProgressBar" + (i + 1).ToString();
                pb.Size = new Size(rowWidth, rowHeight);
                pb.TabIndex = i;
                pb.Value = arrayInput[i];
                pointY += 18;
                i++;
            }
            // 
            // Form1
            // 
            this.CenterToScreen();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(rowWidth + spaceBetweenRows, pointY + spaceBetweenRows); // client size
            this.Name = "Form " + pocetFormularu.ToString();
            this.Text = "Form " + pocetFormularu.ToString();
            for (int iii = 0; iii < arrayInput.Length; iii++) {
                this.Controls.Add(this.progressPole1[iii]);
            }
            pocetFormularu++;
            this.ResumeLayout(false);
            this.SuspendLayout();

            // pocetFormularu++ 0 = buble, 1 = merge?
            //xxpicovina predelat
            //switch (pocetFormularu++) { // asi funguje ale neni idealni
            //    case 0:
            //        //Thread t1 = new Thread(PBBubbleSort); t1.Start();
            //        break;
            //    case 1:
            //        Thread t2 = new Thread(PBMergeSort); t2.Start();
            //        break;
            //    default:
            //        Console.WriteLine("Dalsi neni...");
            //        break;
            //}
            Thread t1 = new Thread(PBBubbleSort); t1.Start();
            //Thread t2 = new Thread(PBMergeSort); t2.Start();
        }
        public void PBBubbleSort() {
            int i = 0;
            for (int j = 0; j < progressPole1.Length - 1; j++) {
                for (i = 0; i < progressPole1.Length - 1 - j; i++) {
                    if (progressPole1[i].Value > progressPole1[i + 1].Value) {
                        //ProgressBar pbTemp;
                        //pbTemp = progressPole1[i];
                        //progressPole1[i] = progressPole1[i + 1];
                        //progressPole1[i + 1] = pbTemp;
                        int pbTempVal = progressPole1[i].Value;
                        progressPole1[i].Value = progressPole1[i + 1].Value;
                        progressPole1[i + 1].Value = pbTempVal;
                    }
                    Thread.Sleep(100);
                }
            }
        }
        // dalsi metoda na rideni, thread se zapne nekde jinde asi
        public void PBMergeSort() {
            // Merges two subarrays of []arr.
            // First subarray is arr[l..m]
            // Second subarray is arr[m+1..r]
            int polovina;
            if (poleCisel.Length % 2 == 0) {
                polovina = poleCisel.Length / 2;
            }
            else {
                polovina = poleCisel.Length - 1 / 2;
            }
            merge(poleCisel, 0, polovina, poleCisel.Length+1);
            
            void merge(int[] arr, int l, int m, int r) {
                arr = this.poleCisel;
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = l;
                while (i < n1 && j < n2) {
                    if (L[i] <= R[j]) {
                        arr[k] = L[i];
                        i++;
                    }
                    else {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1) {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2) {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            // Main function that
            // sorts arr[l..r] using
            // merge()
            void sort(int[] arr, int l, int r) {
                if (l < r) {
                    // Find the middle
                    // point
                    int m = l + (r - l) / 2;

                    // Sort first and
                    // second halves
                    sort(arr, l, m);
                    sort(arr, m + 1, r);

                    // Merge the sorted halves
                    merge(arr, l, m, r);
                    Thread.Sleep(100);
                }
            }

            // A utility function to
            // print array of size n */
            void printArray(int[] arr) {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

            // Driver code
            //void Main(String[] args) {
            //    int[] arr = { 12, 11, 13, 5, 6, 7 };
            //    Console.WriteLine("Given Array");
            //    printArray(arr);
            //    //MergeSort ob = new MergeSort();
            //    //ob.sort(arr, 0, arr.Length - 1);
            //    Console.WriteLine("\nSorted array");
            //    printArray(arr);
            //}


        }
        private ProgressBar[] progressPole1;
    }
}

