
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Account10 {
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            if (balance + amount < 0) {
                throw new ArgumentOutOfRangeException("Nedostatek penez pro vyber... Na ucte je: " + balance);
            }
            balance += amount;
        }
        public int writeBalance() { //spis string
            //Console.WriteLine($" je {balance},-"); // tady chci dostat nazev promenne ale asi jen pomoci property?
            return balance;
        }
        //public void writeBalance() {
        //    Console.WriteLine($"Na uctu je: {balance}");
        //}
        public int writeBalanceInDolars(int kurz) {
            try {
                return balance / kurz;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Deleni nulou!" + e.Message);
                return balance;
            }
            catch (ArithmeticException e) {
                Console.WriteLine("Nejaka dalsi vyjimka co se pocitani tyce." + e.Message);
                return balance;
            }
            catch (Exception e) {
                Console.WriteLine("Nejaka dalsi vyjimka co se pocitani tyce. Exception" + e.Message);
                return balance;
            }
        }
        public double writeBalanceInDolarsDouble(double kurz) { // vypise otaznik
            try {
                if (kurz == 0) throw new DivideByZeroException();
                return balance / kurz;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Deleni nulou!");
                return balance;
            }
        }
        public void transferTo(Account account, int amount) {
            try {
                if (amount < 0) {
                    throw new ArgumentOutOfRangeException("Zadana zaporna castka...");
                }
                if (amount > this.balance) {
                    throw new ArgumentOutOfRangeException("Nedostatek penez pro prevod... Na ucte je: " + balance + " ");
                }
                if (amount == 0) {
                    throw new ArgumentOutOfRangeException("Nelze prevest 0,-");
                }
                if (account == this) {
                    throw new ArgumentOutOfRangeException("Nemuzes poslat penize sam sobe...");
                }
                this.balance -= amount;
                account.balance += amount;
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("[" + e.Message.ToString() + "]");
                //throw;
            }
        }
        //public void transferTo(Account ucet, int castka) { // zkusit
        //    try {
        //        if (castka > balance) {
        //            throw new Exception("TransferTo() říká: Na účtu není dost peněz");
        //        }
        //        else if (castka < 0) {
        //            throw new Exception("TransferTo() říká: Nemůžeš vysát prachy...");
        //        }
        //        else if (castka == 0) {
        //            throw new Exception("TransferTo() říká: Posíláš nulu, jo? Pereš prachy, jo?");
        //        }
        //        else if (this == ucet) {
        //            throw new Exception("TransferTo() říká: To se jako snažíš poslat prachy sám sobě, jo?");


        //        }
        //        ucet.balance += castka;
        //        this.balance -= castka;

        //    }
        //    catch (Exception e) {
        //        Console.WriteLine(e.Message);
        //    }

        //}
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
            try {
                u1.insertInto(amount);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine($"Zadano: {amount},- \t ");
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            //Console.WriteLine(u1.writeBalanceInDolars(20));
            //Console.WriteLine(u1.writeBalanceInDolars(0));
            //Console.WriteLine(u1.writeBalanceInDolarsDouble(20));
            //Console.WriteLine(u1.writeBalanceInDolarsDouble(0));
            Console.WriteLine("Kolik penez chcete poslat z 1. uctu na 2. ucet?");
            amount = Int32.Parse(Console.ReadLine());
            try {
                u1.transferTo(u2, amount);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            //Console.WriteLine("Kolik penez chcete poslat z 1. uctu na 1. ucet? - nesmysl");
            //try {
            //    amount = Int32.Parse(Console.ReadLine());
            //}
            //catch (FormatException e) {
            //    Console.WriteLine("Zadano nic." + e.Message);
            //    //throw;
            //    amount = 0;
            //}
            //catch (NullReferenceException e) {
            //    amount = 0;
            //    throw;
            //}
            //u1.transferTo(u1,amount);
        }
    }
}
