using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccountVlastni9 {
    public class MaloPenezException : Exception {

    }
    public class VyberZCizihoUctuException : Exception {

    }
    public class PrevodNulyException : Exception {

    }
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            try {
                if (balance + amount < 0) throw new MaloPenezException();
                balance += amount;
            } catch (MaloPenezException e) {
                //Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + balance +"\n"+ e.Message + "\n" + e.StackTrace + "\n" + e);
                Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + balance);
            }
        }
        public int writeBalance() { //spis string
            //Console.WriteLine($" je {balance},-"); // tady chci dostat nazev promenne ale asi jen pomoci property?
            return balance;
        }
        public void transferTo(Account account, int amount) {
            try {
                if (amount < 0) {
                    throw new VyberZCizihoUctuException();
                }
                if (amount > this.balance) {
                    throw new MaloPenezException();
                }
                if (amount == 0) {
                    throw new PrevodNulyException();
                }
                if (account == this) {
                    throw new ArgumentOutOfRangeException("Nemuzes poslat penize sam sobe...");
                }
                this.balance -= amount;
                account.balance += amount;
            }
            //catch (MaloPenezException e) { Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + balance + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); } // + e.Message + e.StackTrace + e
            //catch (VyberZCizihoUctuException e) { Console.WriteLine("Zadana zaporna castka..." + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
            //catch (PrevodNulyException e) { Console.WriteLine("Nelze poslat 0,-" + "\n" + e.Message + "\n" + e.StackTrace + "\n" + e); }
            catch (MaloPenezException e) { Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + balance); } // + e.Message + e.StackTrace + e
            catch (VyberZCizihoUctuException e) { Console.WriteLine("Zadana zaporna castka..."); }
            catch (PrevodNulyException e) { Console.WriteLine("Nelze poslat 0,-"); }
        }
    }
    public class TestAccount {
        public static void Mainx() {
            Account u1 = new Account();
            Account u2 = new Account();
            u1.balance = 500; // startovne
            int amount = 0;
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            Console.Write("Vklad/vyber penez na u1: ");
            amount = Int32.Parse(Console.ReadLine());
            u1.insertInto(amount);
            Console.WriteLine($"Zadano: {amount},- \t ");
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            Console.WriteLine("Kolik penez chcete poslat z 1. uctu na 2. ucet?");
            amount = Int32.Parse(Console.ReadLine());
            u1.transferTo(u2, amount);
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
        }
    }
}
