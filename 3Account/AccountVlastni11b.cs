using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccountVlastni11b {
    public class MaloPenezException : Exception {
        public MaloPenezException (string s) : base (s) {}
    }
    public class VyberZCizihoUctuException : Exception {
        public VyberZCizihoUctuException(string s) : base(s) { }
    }
    public class PrevodNulyException : Exception {
        public PrevodNulyException(string s) : base(s) { }
    }
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            if (balance + amount < 0) {
                throw new MaloPenezException("Nedostatek penez pro vyber... Na ucte je: " + balance);
            }
            if (amount == 0) {
                throw new PrevodNulyException("Nelze poslat 0,-");
            }
            // zaporna castka je pro vyber, kladna pro vklad
            balance += amount;
        }
        public int writeBalance() { //spis string
            return balance;
        }
        public void transferTo(Account account, int amount) {
            if (amount < 0) {
                throw new VyberZCizihoUctuException("Zadana zaporna castka..."); // + e.Message + e.StackTrace + e
            }
            if (amount > this.balance) {
                throw new MaloPenezException("Nedostatek penez pro vyber... Na ucte je: " + balance);
            }
            if (amount == 0) {
                throw new PrevodNulyException("Nelze poslat 0,-");
            }
            //if (account == this) { // tohle nekontroluju
            //    throw new ArgumentOutOfRangeException("Nemuzes poslat penize sam sobe...");
            //}
            this.balance -= amount;
            account.balance += amount;
        }
    }
    public class TestAccount {
        public static void Mainx() {
            Account u1 = new Account();
            Account u2 = new Account();
            u1.balance = 500; // startovne
            int amount = 0;
            bool ok;
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            do {
                Console.Write("Vklad/vyber penez na u1: ");
                amount = Int32.Parse(Console.ReadLine());
                try {
                    u1.insertInto(amount);
                    break;
                }
                //catch (MaloPenezException e) { Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + u1.balance + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); } 
                //catch (VyberZCizihoUctuException e) { Console.WriteLine("Zadana zaporna castka..." + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
                //catch (PrevodNulyException e) { Console.WriteLine("Nelze poslat 0,-" + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
                catch (MaloPenezException e) { Console.WriteLine(e.Message); } // + e.Message + e.StackTrace + e
                catch (VyberZCizihoUctuException e) { Console.WriteLine(e.Message); }
                catch (PrevodNulyException e) { Console.WriteLine(e.Message); }
            } while (true);
            Console.WriteLine($"Zadano: {amount},- \t ");
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            do {
                ok = true;
                Console.WriteLine("Kolik penez chcete poslat z 1. uctu na 2. ucet?");
                amount = Int32.Parse(Console.ReadLine());
                try {
                    u1.transferTo(u2, amount);
                }
                //catch (MaloPenezException e) { ok = false; Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + u1.balance + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); } // + e.Message + e.StackTrace + e
                //catch (VyberZCizihoUctuException e) { ok = false; Console.WriteLine("Zadana zaporna castka..." + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
                //catch (PrevodNulyException e) { ok = false; Console.WriteLine("Nelze poslat 0,-" + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
                catch (MaloPenezException e) { ok = false; Console.WriteLine(e.Message); } // + e.Message + e.StackTrace + e
                catch (VyberZCizihoUctuException e) { ok = false; Console.WriteLine(e.Message); }
                catch (PrevodNulyException e) { ok = false; Console.WriteLine(e.Message); }
            } while (!ok);
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
        }
    }
}