using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account3 {
    public class Person {
        public string name;
        public int age;
        public Account myAccount;
        public Person() { }
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
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
            owner.myAccount = this;
        }
        public Account(int amount, string name, int age) {
            this.balance = amount;
            this.owner = new Person(name, age);
            this.owner.myAccount = this;
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
            Account u1 = new Account(500, "Adam", 30);
            Account u2 = new Account(300, "Eva", 30);
            u1.writeBalance();
            u2.writeBalance();
            Console.WriteLine("oba ucty +100,-");
            u1.insertInto(100);
            u2.insertInto(100);
            u1.writeBalance();
            u2.writeBalance();
            //Account u3 = new Account();
            //u3.writeBalance();
            Account u4 = new Account();
            Console.WriteLine(u4.balance);
            Person o1 = new Person("Karel", 44);
            Person o2 = new Person("Pavel", 33);
            Account u5 = new Account(100, o1);
            Account u6 = new Account(200, o2);
            u5.writeBalance(); u6.writeBalance();
            Console.WriteLine("----------------");
            Console.WriteLine(u5.ToString());
            Console.WriteLine(u6.ToString());
            Console.WriteLine(u5.owner.name);
            Console.WriteLine(u6.owner.name);
            Console.WriteLine("----------------");
            Console.WriteLine($"Jmeno: {o1.name} \t Stav: {o1.myAccount.balance},-");
            o1.myAccount.writeBalance();
        }
    }
}
