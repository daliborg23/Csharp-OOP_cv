using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Engine {
		public enum EEngine { elektricka, diesel, parni };
		private EEngine type;
		public EEngine Type {
			get { return type; }
			set { type = value; }
		}
        public Engine(int type) {
			Type = (EEngine)type;
		}
        public Engine(EEngine type) {
            Type = type;
        }
        public override string ToString() {
			string s = string.Empty;
			switch ((int)Type) {
				case 0:
					s = "parnim"; break;
				case 1:
					s = "diselovym"; break;
				case 2:
					s = "elektrickym"; break;
				default:
					s = "NECO JE SPATNE"; break;
			}
			return $"{s} motorem";
        }

    }
}
