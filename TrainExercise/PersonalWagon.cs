using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public interface IConnectable {
        void ConnectWagon(Train train);
        void DisconnectWagon(Train train);
    }
    public abstract class PersonalWagon {
		private List<Door> doors;
		private List<Chair> sits;
		private int numberOfChairs;

		#region properties
		public List<Door> Doors {
			get { return doors; }
			set { doors = value; }
		}
		public List<Chair> Sits {
			get { return sits; }
			set { sits = value; }
		}
		public int NumberOfChairs {
			get { return numberOfChairs; }
			set { numberOfChairs = value; }
		}
		#endregion
		public PersonalWagon(int numberOfChairs) {
			NumberOfChairs = numberOfChairs;
            // nevim
		}
	   //     public abstract Train ConnectToTrain() {
				//// if engine = parni && vagony > 5 => problem
	   //     }
	   //     public abstract Train DisconnectFromTrain() {
				//// je vlak pripojeny k onomu vlaku? 
	   //     }
        //Train ConnectWagon();
        //Train DisconnectWagon();
    }
}
