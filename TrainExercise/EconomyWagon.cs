using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class EconomyWagon : PersonalWagon, IConnectable {
        public EconomyWagon(int numberOfChairs) : base (numberOfChairs) {}
        public override string ToString() {
            //return base.ToString();
            return $"Vagon Economy s {NumberOfChairs} misty k sezeni.";
        }
        public void ConnectWagon(Train train) {
            train.Wagons.Add(this);
        }
        public void DisconnectWagon(Train train) {
            train.Wagons.Remove(this);
        }
    }
}
