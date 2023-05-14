using System;
using System.Drawing;
using System.Windows.Forms;

namespace VlaknaTrideni
{
	public class Form4orig : Form
	{
		public Form4orig(int[] data)
		{                                                //
			int rowHeight = 20; int rowWidth = 400; int spaceBetweenRows = 10;
			int pbCount = 15; int margin = 10;
			for (int x = 0; x < data.Length; x++)
			{                                 //
				ProgressBar pBar = new ProgressBar();
				pBar.Location = new Point(margin, rowHeight + x * (rowHeight + spaceBetweenRows));
				pBar.Name = "pBar" + x;
				pBar.Size = new Size(rowWidth, rowHeight);
				pBar.Value = data[x];                                  //
				Controls.Add(pBar);

			}
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(rowWidth + 2 * margin, margin + pbCount * (rowHeight + spaceBetweenRows) + margin);
			Name = "Form4"; Text = "Form4";
		}
	}
}
