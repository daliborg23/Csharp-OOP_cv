using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Hopper : IConnectable {
		private double loadingCapacity;
		#region properties
		public double LoadingCapacity {
			get { return loadingCapacity; }
			set { loadingCapacity = value; }
		}
		#endregion
		public Hopper(double tonnage) {
			loadingCapacity = tonnage;
			// if - pokud by vaha byla moc velka?
		}
        public override string ToString() {
			return $"Vagon Hopper(na sypky material) ma nosnost {LoadingCapacity} tun.";
        }
        public void ConnectWagon(Train train) {
            train.Wagons.Add(this);
        }
        public void DisconnectWagon(Train train) {
            train.Wagons.Remove(this);
        }
    }
}
