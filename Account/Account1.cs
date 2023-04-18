using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1 {
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            if (amount > 0) { // +vklad -vyber
                balance += amount;
            } else {
                balance -= amount;
            }
        }
        public int writeBalance() {
            return balance;
        }
        public void transferTo(Account account, int amount) {
            this.balance -= amount;
            account.balance += amount;
        }
    }
    public class TestAccount {
        public static void Main() {
            Account u1 = new Account();
            Account u2 = new Account();
            u1.insertInto(100);
            u2.insertInto(100);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            u1.transferTo(u2, 50);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            u1.transferTo(u2, 50);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
        }
    }
}
