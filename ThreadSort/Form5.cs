using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ThreadSort {
    public class Form5 : Form {
        private ProgressBar[] progressPole1;
        static int pocetFormularu;
        int[] poleCisel;
        string typRazeni;
        static int posX;
        static int posY;
        DateTime dtn;
        private Label label1;

        public Form5(int[] arrayInput, string typRazeni) {
            this.poleCisel = arrayInput;
            this.typRazeni = typRazeni;
            this.dtn = DateTime.Now;
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
            int pointY = 20;

            foreach (ProgressBar pb in progressPole1) {
                pb.Location = new Point(pointX, pointY);
                pb.Name = "ProgressBar" + (i + 1).ToString();
                pb.Size = new Size(rowWidth, rowHeight);
                pb.Value = arrayInput[i];
                pb.ForeColor = Color.DarkSlateBlue;
                pointY += 18;
                i++;
            }
            pointY -= 18;
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
            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(10, 4);
            this.label1.Name = "LoopCounterAndTimer";
            this.label1.Size = new Size(35, 13);
            this.Controls.Add(this.label1);
            this.ResumeLayout(false); // ?
            this.SuspendLayout();
        }
        private void btnExit_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
        public void PBBubbleSort() {
            this.Text = typRazeni;
            int pbTempVal;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            for (int j = 0; j < progressPole1.Length - 1; j++) {
                for (int i = 0; i < progressPole1.Length - 1; i++) {
                    if (progressPole1[i].Value > progressPole1[i + 1].Value) {
                        try {
                            pbTempVal = progressPole1[i].Value;
                            progressPole1[i].Value = progressPole1[i + 1].Value;
                            progressPole1[i + 1].Value = pbTempVal;
                            //progressPole1[i].Refresh();
                        }
                        catch (Exception) {
                            // $exception	{"Cross-thread operation not valid: Control 'ProgressBar1' accessed from a thread other than the thread it was created on."}	System.InvalidOperationException
                            // Invoke, BeginInvoke, BackgroundWorker
                            //throw;
                        }
                    }
                    indexLoopIn++;
                    progressPole1[i].ForeColor = Color.DarkTurquoise;
                    progressPole1[i + 1].ForeColor = Color.DarkRed;
                    this.label1.Text = (indexLoopOut + 1).ToString() + " - " + (indexLoopIn + 1).ToString() + " - " + (DateTime.Now - dtn).TotalMilliseconds.ToString("N2") + "ms";

                    Thread.Sleep(50);
                }
                indexLoopOut++;
                Thread.Sleep(250);
            }
        }
        public void PBBubbleSortOptim() {
            this.Text = typRazeni;
            int lastSwapIndex = progressPole1.Length;
            int currentSwapIndex;
            int pbTempVal;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            do {
                currentSwapIndex = 0;
                for (int i = 0; i < lastSwapIndex - 1; i++) {
                    if (progressPole1[i].Value > progressPole1[i + 1].Value) {
                        pbTempVal = progressPole1[i].Value;
                        progressPole1[i].Value = progressPole1[i + 1].Value;
                        progressPole1[i + 1].Value = pbTempVal;
                        currentSwapIndex = i + 1;
                    }
                    indexLoopIn++;
                    progressPole1[i].ForeColor = Color.DimGray;
                    progressPole1[i + 1].ForeColor = Color.LimeGreen;
                    this.label1.Text = (indexLoopOut + 1).ToString() + " - " + (indexLoopIn + 1).ToString() + " - " + (DateTime.Now - dtn).TotalMilliseconds.ToString("N2") + "ms";

                    Thread.Sleep(50);
                }
                lastSwapIndex = currentSwapIndex;
                indexLoopOut++;
                Thread.Sleep(250);
            } while (lastSwapIndex > 0);
        }
        public void SelectionSort() {
            this.Text = typRazeni;
            int indexLoopOut = 0;
            int indexLoopIn = 0;
            if (progressPole1.Length <= 1)
                return;

            var arrayLength = progressPole1.Length;

            for (int i = 0; i < arrayLength - 1; i++) {
                int minIndex = i;

                for (int j = i + 1; j < arrayLength; j++) {
                    if (progressPole1[j].Value < progressPole1[minIndex].Value) {
                        minIndex = j;
                    }
                    indexLoopIn++;

                    //form4.showData(j, j + 1, indexLoopOut, indexLoopIn, name);
                    progressPole1[i].ForeColor = Color.Tomato;
                    progressPole1[i + 1].ForeColor = Color.DarkSeaGreen;
                    this.label1.Text = (indexLoopOut + 1).ToString() + " - " + (indexLoopIn + 1).ToString() + " - " + (DateTime.Now - dtn).TotalMilliseconds.ToString("N2") + "ms";

                    Thread.Sleep(50);
                }

                if (minIndex != i) {
                    SwapInts(progressPole1, i, minIndex);
                }
                void SwapInts(ProgressBar[] array, int index, int min) {
                    // Swaps elements in an array.
                    int temp = array[index].Value;
                    array[index].Value = array[min].Value;
                    array[min].Value = temp;
                }
                indexLoopOut++;
                Thread.Sleep(500);
            }
        }
    }
}


