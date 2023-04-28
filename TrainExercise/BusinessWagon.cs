using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class BusinessWagon : PersonalWagon, IConnectable {
        private Person steward;
        #region properties
        public Person Steward {
            get { return steward; }
            set { steward = value; } 
        }
        #endregion
        public BusinessWagon(Person steward, int numberOfChairs) 
            : base (numberOfChairs) { 
            Steward = steward;
        }
        public override string ToString() {
            return $"Vagon Business s {NumberOfChairs} misty k sezeni a stewardem {Steward}";
        }
        public void ConnectWagon(Train train) {
            train.Wagons.Add(this);
        }
        public void DisconnectWagon(Train train) {
            train.Wagons.Remove(this);
        }
    }
}
