using System;
using System.Drawing;
using System.Windows.Forms;

namespace VlaknaTrideni {
    public class Form6orig : Form {
        ProgressBar[] progressBars;
        int[] data;
        public Form6orig(int[] data) {
            progressBars = new ProgressBar[data.Length];
            this.data = data;
            int rowHeight = 20; int rowWidth = 400; int spaceBetweenRows = 10;
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
            //showData();
        }
        public void showData(int indexA, int indexB) {
            for (int i = 0; i < progressBars.Length; i++) {
                if (i == indexA || i == indexB) {
                    progressBars[i].ForeColor = Color.Red;
                }
                else if (i > indexB) {
                    progressBars[i].ForeColor = Color.Blue;
                }
                else {
                    progressBars[i].ForeColor = Color.Orange;
                }
                progressBars[i].Value = data[i];
                progressBars[i].Refresh();
            }
        }
        public void bubbleSortSimple() {

        }
    }
}
