using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Bed {
		private int number;
		private bool reserved;
		#region properties
		public int Number {
			get { return number; }
			set { number = value; }
		}
		public bool Reserved {
			get { return reserved; }
			set { reserved = value; }
		}
		#endregion
		public Bed() {
			Number = Number+1;
			Reserved = false;
		}
	}
}
