using System;
using System.Drawing;
using System.Windows.Forms;

namespace VlaknaTrideni {
    public class Form6orig : Form {
        ProgressBar[] progressBars;
        int[] data;
        DateTime dtn;
        private Label label1;
        public Form6orig(int[] data) {
            progressBars = new ProgressBar[data.Length];
            this.data = data;
            this.dtn = DateTime.Now;
            int rowHeight = 20; int rowWidth = 300; int spaceBetweenRows = 10;
            int pbCount = 15; int margin = 10;
            for (int x = 0; x < data.Length; x++) {
                progressBars[x] = new ProgressBar();
                progressBars[x].Location = new Point(margin, rowHeight + x * (rowHeight + spaceBetweenRows));
                progressBars[x].Name = "pBar" + x;
                progressBars[x].Size = new Size(rowWidth, rowHeight);
                //progressBars[x].Value = data[x];
                Controls.Add(progressBars[x]);
            }
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(rowWidth + 2 * margin, margin + pbCount * (rowHeight + spaceBetweenRows) + margin);
            Name = "Form6"; Text = "Form6";
            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(margin, 4);
            this.label1.Name = "LoopCounterAndTimer";
            this.label1.Size = new Size(35, 13);
            this.Controls.Add(this.label1);
            //showData();
        }
        public void showData(int indexA, int indexB, int indexOut, int indexIn, string name) {

            for (int i = 0; i < progressBars.Length; i++) {
                this.Text = name;
                this.label1.Text = (indexOut + 1).ToString() + " - " + (indexIn + 1).ToString() + " - " + (DateTime.Now - dtn).TotalMilliseconds.ToString("N2") + "ms"; 

                progressBars[i].Value = data[i];
                if (i == indexA) {
                    progressBars[i].ForeColor = Color.Red;
                }
                else if (i == indexB) {
                    progressBars[i].ForeColor = Color.Orange;
                }
                else {
                    progressBars[i].ForeColor = Color.Black;
                }

                progressBars[i].Refresh();
            }
        }
    }
}
