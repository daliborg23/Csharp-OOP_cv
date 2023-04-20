using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1b {
    public class Account {
        public int balance;
        //public Account() { }
        public void insertInto(int amount) {
            // +vklad -vyber
            balance += amount;
        }
        public int writeBalance() {
            return balance;
        }
        public void transferTo(Account account, int amount) {
            this.balance -= amount;
            account.balance += amount;
        }
        //public void transferTo(Account account) { // pretezovani x prekryvani = pretezovani s jinaci signaturou // prekryvani se stejnym nazvem a jinou signaturou?
        //    account.balance += this.balance;
        //    this.balance = 0;
        //}
        public void transferTo(Account account) {
            transferTo(account, this.balance);
            //transferTo(account, account.balance); // nesmysl
        }
    }
    public class TestAccount {
        public static void Mainx() {
            Account u1 = new Account();
            Account u2 = new Account();
            u1.insertInto(100);
            u2.insertInto(100);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            u1.transferTo(u2, 50);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            u1.transferTo(u2, 50);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Prevod z u2 na u1");
            u2.transferTo(u1);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            Console.WriteLine("Prevod z u1 na u2");
            u1.transferTo(u2);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            Console.WriteLine("u1 +100,-");
            u1.insertInto(100);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            Console.WriteLine("Prevod z u2 na u1");
            u2.transferTo(u1);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
            Console.WriteLine("u1 -100,-");
            u1.insertInto(-100);
            Console.WriteLine($"ucet1: {u1.writeBalance()},- ucet2: {u2.writeBalance()},-");
        }
    }
}