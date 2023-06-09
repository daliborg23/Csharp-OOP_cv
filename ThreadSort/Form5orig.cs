﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace VlaknaTrideni
{
	public class Form5orig : Form
	{
		ProgressBar[] progressBars;
		int[] data;
		public Form5orig(int[] data)
		{
            progressBars = new ProgressBar[data.Length];
			this.data = data;
            int rowHeight = 20; int rowWidth = 400; int spaceBetweenRows = 10;
			int pbCount = 15; int margin = 10;
			for (int x = 0; x < data.Length; x++)
			{
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
			Name = "Form5"; Text = "Form5";
			//showData();
		}
		public void showData() {
			for (int i = 0; i < progressBars.Length; i++) {
                progressBars[i].Value = data[i];
            }
		}
	}
}
