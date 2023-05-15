using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThreadSort {
    public class Form5 : Form {
        private ProgressBar[] progressPole1;
        static int pocetFormularu;
        int[] poleCisel;
        string typRazeni;
        static int posX;
        static int posY;
        private System.Windows.Forms.Timer timer;
        private int timerCount;
        BackgroundWorker bgw = new BackgroundWorker();
        public Form5(int[] arrayInput, string typRazeni) {
            this.timer = new System.Windows.Forms.Timer();
            this.poleCisel = arrayInput;
            this.typRazeni = typRazeni;
            int rowWidth = 311;
            int rowHeight = 12;
            int spaceBetweenRows = 26;
            pocetFormularu += 1;
            posX += 338; posY = 322;

            //
            // ProgressBars
            //
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
            pointY -= 18;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // Form1
            // 
            //this.CenterToScreen();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(posX, posY);
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(rowWidth + spaceBetweenRows, pointY + spaceBetweenRows); // client size
            this.Name = "Form " + pocetFormularu.ToString();
            this.Text = "Form " + pocetFormularu.ToString();
            for (int iii = 0; iii < arrayInput.Length; iii++) {
                this.Controls.Add(this.progressPole1[iii]);
            }
            this.ResumeLayout(false);
            this.SuspendLayout();
        }
        private async void timer_Tick(object sender, EventArgs e) {
            timerCount++;
            if (timerCount > 1) {
                if (typRazeni == "bubble") {
                    //await Task.Run(() => PBBubbleSort());
                }
                else if (typRazeni == "merge") {
                    //await Task.Run(() => PBMergeSort());
                }
            }
        }
        public void PBBubbleSort() {
            int n = progressPole1.Length;
            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (progressPole1[j].Value > progressPole1[j + 1].Value) {
                        if (progressPole1[j].InvokeRequired || progressPole1[j + 1].InvokeRequired) {
                            int pbTempVal = progressPole1[j].Value;
                            int pbNextVal = progressPole1[j + 1].Value;

                            progressPole1[j].BeginInvoke(new Action(() => progressPole1[j].Value = pbNextVal));
                            progressPole1[j + 1].BeginInvoke(new Action(() => progressPole1[j + 1].Value = pbTempVal));
                        }
                        else {
                            int pbTempVal = progressPole1[j].Value;
                            progressPole1[j].Value = progressPole1[j + 1].Value;
                            progressPole1[j + 1].Value = pbTempVal;
                        }
                    }
                    Thread.Sleep(50);
                }
            }
        }
        public void PBBubbleSort2() {
            int i = 0;
            for (int j = 0; j < progressPole1.Length - 1; j++) {
                for (i = 0; i < progressPole1.Length - 1 - j; i++) {
                    if (progressPole1[i].Value > progressPole1[i + 1].Value) {
                        //ProgressBar pbTemp;
                        //pbTemp = progressPole1[i];
                        //progressPole1[i] = progressPole1[i + 1];
                        //progressPole1[i + 1] = pbTemp;
                        try {
                            int pbTempVal = progressPole1[i].Value;
                            progressPole1[i].Value = progressPole1[i + 1].Value;        // try mozna muzu zkusit smazat
                            progressPole1[i + 1].Value = pbTempVal;
                            //progressPole1[i].Refresh();
                        }
                        catch (Exception) { // +		$exception	{"Cross-thread operation not valid: Control 'ProgressBar1' accessed from a thread other than the thread it was created on."}	System.InvalidOperationException !!!!!!!!!!!!!!!!!!!!!!!!!!

                            throw;
                        }
                    }
                    Thread.Sleep(50);
                }
            }
        }
        // dalsi metoda na rideni, thread se zapne nekde jinde asi
        public void PBMergeSort() {

            // poleCisel, L, R  -> progressbars pole

            Thread.Sleep(2000);
            this.Invoke(new MethodInvoker(delegate {
                // Merges two subarrays of []arr.
                // First subarray is arr[l..m]
                // Second subarray is arr[m+1..r]
                int polovina;
                if (progressPole1.Length % 2 == 0) {
                    polovina = (progressPole1.Length) / 2 - 1; // zkusit pro pole [14], a jeste doplnit threadsleep nekde
                }
                else {
                    polovina = (progressPole1.Length - 1) / 2 + 1; // 15 asi OK
                }
                merge(progressPole1, 1, polovina, progressPole1.Length - 1);

                void merge(ProgressBar[] arr, int l, int m, int r) {
                    arr = this.progressPole1;
                    // Find sizes of two
                    // subarrays to be merged
                    int n1 = m - l + 1;
                    int n2 = r - m;

                    // Create temp arrays
                    ProgressBar[] L = new ProgressBar[n1];
                    ProgressBar[] R = new ProgressBar[n2];
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
                        if (L[i].Value <= R[j].Value) {
                            arr[k].Value = L[i].Value;
                            i++;
                        }
                        else {
                            arr[k].Value = R[j].Value;
                            j++;
                        }
                        k++;
                        Thread.Sleep(100);
                    }

                    // Copy remaining elements
                    // of L[] if any
                    while (i < n1) {
                        arr[k].Value = L[i].Value;
                        i++;
                        k++;
                        Thread.Sleep(100);
                    }

                    // Copy remaining elements
                    // of R[] if any
                    while (j < n2) {
                        arr[k].Value = R[j].Value;
                        j++;
                        k++;
                        Thread.Sleep(100);
                    }
                }
                // Main function that
                // sorts arr[l..r] using
                // merge()
                void sort(ProgressBar[] arr, int l, int r) {
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
                //void printArray(int[] arr) {
                //    int n = arr.Length;
                //    for (int i = 0; i < n; ++i)
                //        Console.Write(arr[i] + " ");
                //    Console.WriteLine();
                //}

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
            }));
        }
    }
}


