using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Locomotive : IConnectable {
        private Person driver;
        private Engine engine;
		public Person Driver {
			get { return driver; }
			set { driver = value; }
		}
		public Engine Engine { 
			get { return engine; } 
			set { engine = value; } 
		}
        public Locomotive(){}
		public Locomotive(Person driver, Engine engine) {
            Driver = driver;
            Engine = engine;
        }
		public override string ToString() {
			return $"Lokomotiva s {Engine.ToString()} a strojvedoucim {Driver}\n";
		}
        public void ConnectWagon(Train train) {
            train.Wagons.Add(this);
        }
        public void DisconnectWagon(Train train) {
            train.Wagons.Remove(this);
        }
    }
}
