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
    public class Form3 : Form {
        int cisloFormu = 1;
        static int pocetFormularu = 0;
        public Form3(int[] arrayInput) {
            int rowWidth = 311;
            int rowHeight = 12;
            int spaceBetweenRows = 13;
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
            this.Name = "Form " + cisloFormu;
            this.Text = "Form " + cisloFormu++;
            for (int iii = 0; iii < arrayInput.Length; iii++) {
                this.Controls.Add(this.progressPole1[iii]);
            }
            this.ResumeLayout(false);
            this.SuspendLayout();

            // pocetFormularu++ 0 = buuble, 1 = merge?
            switch (pocetFormularu) { // asi funguje ale neni idealni
                case 0:
                    //Thread t1 = new Thread(PBBubbleSort); t1.Start();
                    pocetFormularu++;
                    PBBubbleSort();
                    break;
                case 1:
                    //Thread t2 = new Thread(PBMergeSort); t2.Start();
                    pocetFormularu++;
                    PBMergeSort();
                    break;
                default:
                    Console.WriteLine("Dalsi neni...");
                    break;
            }
            
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
                        try {
                            int pbTempVal = progressPole1[i].Value;
                            progressPole1[i].Value = progressPole1[i + 1].Value;
                            progressPole1[i + 1].Value = pbTempVal;
                        }
                        catch (Exception) {
                            //throw;
                        }
                    }
                Thread.Sleep(100);
                }
            }
        }
        // dalsi metoda na rideni, thread se zapne nekde jinde asi
        public void PBMergeSort() {

        }
        private ProgressBar[] progressPole1;
    }
}