using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class NightWagon : PersonalWagon, IConnectable {
		private Bed[] beds;
		private int numberOfBeds;
		#region properties
		public Bed[] Beds {
			get { return beds; }
			set { beds = value; }
		}
		public int NumberOfBeds {
			get { return numberOfBeds; }
			set { numberOfBeds = value; }
		}
		#endregion
		public NightWagon(int numberOfChairs, int numberOfBeds) 
			: base (numberOfChairs) {
			NumberOfBeds = numberOfBeds;
			// nastavit velikost pole?
		}
        public override string ToString() {
			return $"Vagon NightWagon(luzkovy vagon) s {NumberOfChairs} misty k sezeni a s {NumberOfBeds} luzkama.";
        }
        public void ConnectWagon(Train train) {
            train.Wagons.Add(this);
        }
        public void DisconnectWagon(Train train) {
            train.Wagons.Remove(this);
        }
    }
}
