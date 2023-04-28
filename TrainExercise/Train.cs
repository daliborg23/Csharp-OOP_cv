using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TrainExercise {
    public class Train {
        private Locomotive locomotive;
		private List<IConnectable> wagons;
		#region properties
		public Locomotive Locomotive {
			get { return locomotive; }
			set { locomotive = value; }
		}
		public List<IConnectable> Wagons {
			get { return wagons; }
			set { wagons = value; }
		}
		#endregion
		public Train() { }
		public Train(Locomotive locomotive) {
			Locomotive = locomotive;
			// budou se moct pozdeji pripojit vagony?
		}
		public Train(Locomotive locomotive, List<IConnectable> listWagonu) 
			: this (locomotive) {
			Wagons = listWagonu;
		}
		public void ConnectWagon(IConnectable wagon) {
			// parni lokomotiva?
			try {
				if (Locomotive.Engine.Type == "parni" && this.Wagons.Count() >= 5) {
					Console.WriteLine($"Nelze pridat dalsi vagony, chudak lokomotiva s {Locomotive.Engine.ToString()} by to neutahla...");
				} else {
					Console.WriteLine("Pridan do soupravy " + wagon.ToString());
					Wagons.Add(wagon);
				}
			}
			catch (ArgumentNullException e) {
                Console.WriteLine("Pridani prvniho vagonu za lokomotivu\nPridan do soupravy " + wagon.ToString());
				Wagons = new List<IConnectable>();
                Wagons.Add(wagon); // ?
                //throw;
            }
        }
		public void DisconnectWagon(IConnectable wagon) {
            Console.WriteLine("Odebran ze soupravy " + wagon.ToString());
            Wagons.Remove(wagon);
		}
		public void ReserveChair(int cisloWagonu, int cisloSedadla) {
            Console.WriteLine($"Rezervace sedadla c. {cisloSedadla} ve vagonu c. {cisloWagonu}");
			Chair ch = new Chair(cisloSedadla,false);
			List<Chair> sitsss = new List<Chair>();
            if (Wagons[cisloWagonu] is PersonalWagon) { // je osobni?
				try {
					if (((PersonalWagon)this.Wagons[cisloWagonu]).Sits.Contains(ch)) { // esixtuje?
						Console.WriteLine("Sedadlo existuje");
						
					} else {
                        Console.WriteLine("Sedadlo neexistuje");
                    }
				}
				catch (NullReferenceException e) {
                    Console.WriteLine("Sedadlo je prazdne.");
                    //throw;
                }
                //((PersonalWagon)this.Wagons[cisloWagonu]).Sits.Add(ch);
                sitsss.Add(ch);
                //((PersonalWagon)this.Wagons).Sits = ;
            } else {
                Console.WriteLine("Tohle neni vagon pro cestujici!");
            }
			// is osobni wagon? pretypovat
			// wagon existuje? sedadlo existuje? neni rezervoavne?
		}
		public void ListReservedChairs() {
			// vypise reservovane sedadla
		}
        public override string ToString() {
			string s = string.Empty;
			s = $"Vlak: {Locomotive}";
			if (Wagons.Count == 0) {
				s = " jede sama bez dalsich vagonu";
				return s;
			}
			s += " a pripojenyma vagonama:\n";
			//foreach (IConnectable w in Wagons) { 
			//	s += w.ToString() + "\n"; 
			//}
			for (int i = 0; i < Wagons.Count(); i++) {
				if (i == Wagons.Count() - 1) {
					s += Wagons[i].ToString();
                } else {
					s += Wagons[i].ToString() + "\n";
				}
            }
			// vypis vlaku a vsech vagonu
			return s;
        }
    }
}
