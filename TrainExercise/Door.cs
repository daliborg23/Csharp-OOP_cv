using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Door {
		private double height;
		private double width;
		#region properties
		public double Width {
			get { return width; }
			set { width = value; }
		}

		public double Height {
			get { return height; }
			set { height = value; }
		}
		#endregion
		public Door(double height, double width) {
			Height = height;
			Width = width;
		}
	}
}
