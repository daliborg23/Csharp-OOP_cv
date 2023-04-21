using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Account9 {
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            try {
                if (balance + amount < 0) {
                    Console.WriteLine("Nedostatek penez pro vyber... Na ucte je: " + balance);
                    throw new ArgumentOutOfRangeException();
                } else {
                    balance += amount; // +vklad -vyber
                }
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message.ToString());
                //throw;
            }
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
                    Console.WriteLine("Zadana zaporna castka...");
                    throw new ArgumentOutOfRangeException();
                }
                if (amount > this.balance) {
                    Console.WriteLine("Nedostatek penez pro prevod... Na ucte je: " + balance + " ");
                    throw new ArgumentOutOfRangeException();
                }
                else {
                    this.balance -= amount;
                    account.balance += amount;
                }
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("["+e.Message.ToString()+"]");
                //throw;
            }
        }
        //public void transferTo(Account ucet, int castka) {
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
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            Console.Write("Vklad/vyber penez na u1: ");
            int amount;
            try {
                amount = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.WriteLine("Zadano nic." + e.Message);
                //throw;
                amount = 0;
            }
            catch (NullReferenceException e) {
                amount = 0;
                throw;
            }
            u1.insertInto(amount);
            Console.WriteLine($"Zadano: {amount},- \t ");
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
            //Console.WriteLine(u1.writeBalanceInDolars(20));
            //Console.WriteLine(u1.writeBalanceInDolars(0));
            //Console.WriteLine(u1.writeBalanceInDolarsDouble(20));
            //Console.WriteLine(u1.writeBalanceInDolarsDouble(0));
            Console.WriteLine("Kolik penez chcete poslat na 2. ucet?");
            try {
                amount = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e) {
                Console.WriteLine("Zadano nic." + e.Message);
                //throw;
                amount = 0;
            }
            catch (NullReferenceException e) {
                amount = 0;
                throw;
            }
            u1.transferTo(u2,amount);
            Console.WriteLine("Na ucte u1: " + u1.writeBalance() + ",-");
            Console.WriteLine("Na ucte u2: " + u2.writeBalance() + ",-");
        }
    }
}
