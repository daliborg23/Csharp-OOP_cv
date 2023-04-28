using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Chair {
		private bool nearWindow;
		private int number;
		private bool reserved;
		#region properties
		public bool NearWindow {
			get { return nearWindow; }
			set { nearWindow = value; }
		}
		public int Number {
			get { return number; } 
			set {  number = value; } 
		}
        public bool Reserved {
            get { return reserved; }
            set { reserved = value; }
        }
		#endregion
		public Chair(int number, bool nearwindow) {
			Number = number;
			NearWindow = nearwindow;
			//Reserved = true;
        }
    }
}
