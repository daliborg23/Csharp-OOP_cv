using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Engine {
		//diesel, elektrická, parní
		public enum EEngine { elektricka, diesel, parni };

		private string type;
		public string Type {
			get { return type; }
			set { type = value; }
		}
        public Engine(string type) {
			Type = type;
		}
        public Engine(EEngine type) {
            Type = type.ToString();
        }
        public override string ToString() {
			string s = string.Empty;
			switch (Type) {
				case "diesel":
					s = "diselovym"; break;
				case "parni":
					s = "parnim"; break;
				case "elektricka":
					s = "elektrickym"; break;
				default:
					s = "NECO JE SPATNE"; break;
			}
			return $"{s} motorem";
        }

    }
}
