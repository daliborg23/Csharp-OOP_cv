using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account7 {
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            balance += amount; // +vklad -vyber
        }
        public int writeBalance() { //spis string
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
            this.balance -= amount;
            account.balance += amount;
        }
    }
    public class TestAccount {
        public static void Mainx() {
            Account u1 = new Account();
            Console.Write("Vklad penez: ");
            int amount = Int32.Parse(Console.ReadLine());
            u1.insertInto(amount);
            Console.WriteLine($"Zadano: {u1.writeBalance()},-");
            Console.WriteLine(u1.writeBalanceInDolars(20));
            Console.WriteLine(u1.writeBalanceInDolars(0));
            Console.WriteLine(u1.writeBalanceInDolarsDouble(20));
            Console.WriteLine(u1.writeBalanceInDolarsDouble(0));

        }
    }
}
