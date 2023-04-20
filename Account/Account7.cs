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
        }
    }
}
