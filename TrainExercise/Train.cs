using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TrainExercise;

namespace TrainExercise {
    public class Train {
        private List<Locomotive> locomotive;
        private List<IConnectable> wagons;
        #region properties
        public List<Locomotive> Locomotive {
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
            Locomotive = new List<Locomotive>() { locomotive };
            Wagons = new List<IConnectable>();
            // budou se moct pozdeji pripojit vagony?
        }
        public Train(Locomotive locomotive, List<IConnectable> listWagonu)
            : this(locomotive) {
            Wagons = listWagonu;
        }
        public void ConnectWagon(IConnectable wagon) {
            // parni lokomotiva?
            try {
                if ((int)Locomotive[0].Engine.Type == 2 && this.Wagons.Count() >= 5) {
                    Console.WriteLine($"Nelze pridat dalsi vagony, chudak lokomotiva s {Locomotive[0].Engine.ToString()} by to neutahla...");
                }
                else {
                    Console.WriteLine("Pridan do soupravy " + wagon.ToString());
                    Wagons.Add(wagon);
                    //Console.WriteLine(Wagons.Count());
                }
            }
            catch (ArgumentNullException e) {
                Console.WriteLine("Pridani prvniho vagonu za lokomotivu\nPridan do soupravy " + wagon.ToString());
                Wagons = new List<IConnectable>();
                Wagons.Add(wagon); // ?
            }
        }
        public void DisconnectWagon(IConnectable wagon) {
            Console.WriteLine("Odebran ze soupravy " + wagon.ToString());
            Wagons.Remove(wagon);
        }
        public void ReserveChair(int cisloWagonu, int seatNumber) {
            if (Wagons[cisloWagonu - 1] is PersonalWagon) {
                if (cisloWagonu <= wagons.Count && cisloWagonu > 0) {
                    if (seatNumber <= ((PersonalWagon)wagons[cisloWagonu - 1]).NumberOfChairs && seatNumber > 0) {
                        if (((PersonalWagon)wagons[cisloWagonu - 1]).Sits[seatNumber - 1].Reserved == false) {
                            ((PersonalWagon)wagons[cisloWagonu - 1]).Sits[seatNumber - 1].Reserved = true;
                            Console.WriteLine($"Misto c. {seatNumber} ve vagonu {cisloWagonu} bylo rezervovano.");
                        }
                        else {
                            Console.WriteLine("Misto uz nekdo rezervoval");
                        }
                    }
                    else {
                        Console.WriteLine("Neni misto ve vagonu.");
                    }
                }
                else {
                    Console.WriteLine("Tak dlouhy vlak neni.");
                }
            }
            else {
                Console.WriteLine($"Tohle neni vagon pro cestujici.");
            }
        }
        public void ReserveChair(int cisloWagonu, int seatNumber, int cardNumber) {
            if (Wagons[cisloWagonu - 1] is PersonalWagon) {
                if (cisloWagonu <= wagons.Count && cisloWagonu > 0) {
                    if (seatNumber <= ((PersonalWagon)wagons[cisloWagonu - 1]).NumberOfChairs && seatNumber > 0) {
                        if (((PersonalWagon)wagons[cisloWagonu - 1]).Sits[seatNumber - 1].Reserved == false) {
                            ((PersonalWagon)wagons[cisloWagonu - 1]).Sits[seatNumber - 1].Reserved = true;
                            ((PersonalWagon)wagons[cisloWagonu - 1]).Sits[seatNumber - 1].reservedToCardNo = cardNumber;
                            Console.WriteLine($"Misto c. {seatNumber} ve vagonu {cisloWagonu} bylo rezervovano.");
                        }
                        else {
                            Console.WriteLine("Misto uz nekdo rezervoval");
                        }
                    }
                    else {
                        Console.WriteLine("Neni misto ve vagonu.");
                    }
                }
                else {
                    Console.WriteLine("Tak dlouhy vlak neni.");
                }
            }
            else {
                Console.WriteLine($"Tohle neni vagon pro cestujici.");
            }
        }
        public void ListReservedChairs() {
            // vypise reservovane sedadla
            foreach (IConnectable wagon in Wagons) {
                if (wagon is PersonalWagon) {
                    Console.WriteLine($"Rezervovana mista ve vagonu {wagon.GetType().Name}:");
                    foreach (Chair chair in ((PersonalWagon)wagon).Sits) {
                        if (chair.Reserved == true) {
                            Console.WriteLine($"Pozice: {chair.Number} - cislo karty cestovatele - {chair.reservedToCardNo}");
                        }
                    }
                }
            }
        }
        public override string ToString() {
            string s = string.Empty;
            //s = $"Vlak: {Locomotive}";
            s = $"======Vlakova souprava:======\n";
            foreach (Locomotive locomotive in Locomotive) {
                s += locomotive.ToString();
            }
            if (Wagons.Count == 0) {
                s += " jede sama bez dalsich vagonu";
                return s;
            }
            //s += "a pripojenyma vagonama:\n";
            //foreach (IConnectable w in Wagons) { 
            //	s += w.ToString() + "\n"; 
            //}
            for (int i = 0; i < Wagons.Count(); i++) {
                if (i == Wagons.Count() - 1) {
                    s += Wagons[i].ToString();
                }
                else {
                    s += Wagons[i].ToString() + "\n";
                }
            }
            // vypis vlaku a vsech vagonu
            return s;
        }
        public static Train operator +(Train train, Train other) {
            foreach (IConnectable c in other.Wagons) {
                //train.ConnectWagon(c);
                train.Wagons.Add(c);
            }
            other.Wagons.Clear();
            train.Locomotive.Add(other.Locomotive[0]);
            other.Locomotive.Remove(other.Locomotive[0]);
            other = null;
            return train;
        }
        public static Train operator -(Train train, int pocet) {
            int max = train.Wagons.Count();
            for (int i = max - 1; i > max - pocet - 1; i--) {
                train.DisconnectWagon(train.Wagons[i]);
            }
            return train;
        }
        public static bool operator ==(Train train, Train other) {
            if (train.Locomotive.Count() == other.Locomotive.Count()) {
                for (int i = 0; i < train.Locomotive.Count(); i++) {
                    if (train.Locomotive[i].Engine.Type != other.Locomotive[i].Engine.Type) {
                        Console.WriteLine("Lokomotivy nejsou stejne razeny. ==");
                        return false;
                    }
                }
            }
            if (train.Wagons.Count() == other.Wagons.Count()) {
                for (int i = 0; i < train.Wagons.Count(); i++) {
                    if (train.Wagons[i].GetType().Name != other.Wagons[i].GetType().Name) {
                        Console.WriteLine("Vagony nejsou stejne razeny. ==");
                        return false;
                    }
                }
            }
            Console.WriteLine("Vlaky jsou stejne serazeny. ==");
            return true;
        }
        public static bool operator !=(Train train, Train other) {
            if (train.Locomotive.Count() == other.Locomotive.Count()) {
                for (int i = 0; i < train.Locomotive.Count(); i++) {
                    if (train.Locomotive[i].Engine.Type == other.Locomotive[i].Engine.Type) {
                        Console.WriteLine("Lokomotivy jsou stejne razeny. !=");
                        return false;
                    }
                }
            }
            if (train.Wagons.Count() == other.Wagons.Count()) {
                for (int i = 0; i < train.Wagons.Count(); i++) {
                    if (train.Wagons[i].GetType().Name == other.Wagons[i].GetType().Name) {
                        Console.WriteLine("Vagony jsou stejne razeny. !=");
                        return false;
                    }
                }
            }
            Console.WriteLine("Vlaky nejsou stejne serazeny. !=");
            return true;
        }
    }
}


//public void ReserveChair(int cisloWagonu, int cisloSedadla) {
//    Console.WriteLine($"Rezervace sedadla c. {cisloSedadla} ve vagonu c. {cisloWagonu}");
//    Chair ch = new Chair(cisloSedadla, false);
//    try {
//        if (Wagons[cisloWagonu] is PersonalWagon) { // je osobni?
//            if (((PersonalWagon)this.Wagons[cisloWagonu]).Sits[0].Number == ch.Number) { // esixtuje?
//                Console.WriteLine("Je zarezervovane");
//            }
//            else {
//                Console.WriteLine("Je volne");
//            }
//            ((PersonalWagon)this.Wagons[cisloWagonu]).Sits.Add(ch);
//            Console.WriteLine($"Rezervovano sedadlo c. {cisloSedadla} ve vagonu c. {cisloWagonu}");
//        }
//    }
//    catch (NullReferenceException e) {
//        Console.WriteLine("Sedadlo je prazdne.");
//        Console.WriteLine($"Rezervovano sedadlo c. {cisloSedadla} ve vagonu c. {cisloWagonu}");
//        //throw;
//    }
//    catch (ArgumentOutOfRangeException e) {
//        Console.WriteLine("Tohle neni vagon pro cestujici!");
//    }
//    // is osobni wagon? pretypovat
//    // wagon existuje? sedadlo existuje? neni rezervoavne?
//}