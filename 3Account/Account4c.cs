using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account4c {
    public class Person {
        public string name;
        public int age;
        //public int countOfAccounts;
        public ArrayList myAccounts = new ArrayList();
        public Person() { }
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public void writeAccounts() {
            //for (int i = 0; i < myAccounts.Count; i++) {
            //    Console.WriteLine($"Majitel: {myAccounts[i]} Ucet: {myAccounts[i].GetType().Name} Stav uctu: {myAccounts[i].balance},-");
            //}
            foreach (Account acc in this.myAccounts) {
                Console.WriteLine($"Majitel: {acc.owner.name} Ucet: {acc.GetType().Name} Stav uctu: {acc.balance},-");
            }
        }
        public override string ToString() {
            string s = string.Empty;
            //for (int i = 0; i < myAccounts.Count; i++) {
            //    s += "Majitel: " + myAccounts[i].owner.name + " Ucet: " + myAccounts[i].GetType().Name + " Stav uctu: " + myAccounts[i].balance + ",-\n";
            //}
            foreach (Account acc in this.myAccounts) {
                //Console.Write($"Majitel: {acc.owner.name} Ucet: {acc.GetType().Name} Stav uctu: {acc.balance},-\n");
                s += "Majitel: " + acc.owner.name + " Ucet: " + acc.GetType().Name + " Stav uctu: " + acc.balance + ",-\n";
            }
            return s;
        }
    }
    public class Account {
        public int balance;
        public Person owner;
        public Account() {

        }
        public Account(int amount, Person owner) {
            this.balance = amount;
            this.owner = owner;
            owner.myAccounts.Add(this);
            //owner.countOfAccounts++;
        }
        public Account(int amount, string name, int age) {
            this.balance = amount;
            this.owner = new Person(name, age);
            this.owner.myAccounts.Add(this);
            //this.owner.countOfAccounts++;
        }
        public void insertInto(int amount) {
            balance += amount; // +vklad -vyber
        }
        //public int writeBalance() {
        //    return balance;
        //}
        public void writeBalance() {
            Console.WriteLine($"Na uctu {owner.name} je: {balance}");
        }
        public void transferTo(Account account, int amount) {
            this.balance -= amount;
            account.balance += amount;
        }
        public override string ToString() {
            return $"Jmeno: {this.owner.name} ({this.owner.age} let) \t Stav uctu: {balance},-";
        }
    }
    public class TestAccount {
        public static void Mainx() {
            Person o1 = new Person("Karel", 44);
            Person o2 = new Person("Pavel", 33);
            Account u1 = new Account(500, "Adam", 30);
            Account u2 = new Account(300, "Eva", 30);
            //Account u3 = new Account();
            Account u4 = new Account();
            Account u5 = new Account(100, o1);
            Account u6 = new Account(200, o2);
            //u1.writeBalance();
            //u2.writeBalance();
            //Console.WriteLine("oba ucty +100,-");
            //u1.insertInto(100);
            //u2.insertInto(100);
            //u1.writeBalance();
            //u2.writeBalance();
            ////u3.writeBalance();
            //Console.WriteLine(u4.balance);
            //u5.writeBalance(); u6.writeBalance();
            //Console.WriteLine("----------------");
            //Console.WriteLine(u5.ToString());
            //Console.WriteLine(u6.ToString());
            //Console.WriteLine(u5.owner.name);
            //Console.WriteLine(u6.owner.name);
            //Console.WriteLine("----------------");
            Console.WriteLine($"Jmeno: {o1.name} \t Stav: {o1.myAccounts[0]},-");
            Console.WriteLine("----------------");
            Console.WriteLine(o1.myAccounts[0]);
            Account u10 = new Account(200, o1);
            Account u11 = new Account(333, o1);
            Console.WriteLine("----------------");
            o1.writeAccounts();
            Console.WriteLine("----------------");
            Console.WriteLine(o1.ToString());
        }
    }
}
