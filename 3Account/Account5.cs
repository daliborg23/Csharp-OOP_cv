using System;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account5 {
    public class Date {
        public int day;
        public int month;
        public int year;
        public Date(){}
        public Date(int d, int m, int y) {
            this.day = d;
            this.month = m;
            this.year = y;
        }
    }
    public class Person {
        public string name;
        public Date dateOfBirth;
        //public int age;
        public ArrayList myAccounts = new ArrayList();
        public Person() { }
        public Person(string name, Date dateOfBirth) {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
        public Person(string name, int day, int month, int year) {
            ///new Person(name,/// dateOfBirth = new Date(day, month,year)); // ??????????
            this.name = name;
            //dateOfBirth = new Date(day, month, year);
        }
        //public Person(string name, int day, int month, int year) {
        //    this.name = name;
        //    dateOfBirth = new Date(day, month, year);
        //}
        public int getAge() {
            DateTime birthDay = DateTime.Parse($"{dateOfBirth.month}/{dateOfBirth.day}/{dateOfBirth.year}");
            int age;
            //Console.WriteLine(DateTime.Now.CompareTo(birthDay));
            if (DateTime.Now.DayOfYear < birthDay.DayOfYear) {
                age = DateTime.Now.Year - dateOfBirth.year;
            } else {
                age = DateTime.Now.Year - dateOfBirth.year - 1;
            }
            return age;
        }
        public void writeAccounts() {
            foreach (Account acc in this.myAccounts) {
                Console.WriteLine($"Majitel: {acc.owner.name} ({DateTime.Now.Year-acc.owner.dateOfBirth.year} let) Ucet: {acc.GetType().Name} Stav uctu: {acc.balance},-");
            }
        }
        public override string ToString() {
            return $"{name} ({getAge()} let) \t Pocet zalozenych uctu: {myAccounts.Count}";
        }
    }
    public class Account {
        public int balance;
        public Person owner;
        public Account() {}
        public Account(int amount, Person owner) {
            this.balance = amount;
            this.owner = owner;
            owner.myAccounts.Add(this);
        }
        //public Account(int amount, string name, int age) {
        //    age = DateTime.Now.Year - owner.dateOfBirth.year;
        //    this.balance = amount;
        //    this.owner = new Person(name, new Date(1,1,age));
        //    this.owner.myAccounts.Add(this);
        //}
        public void insertInto(int amount) {
            balance += amount; // +vklad -vyber
        }
        public void writeBalance() {
            int age = DateTime.Now.Year - owner.dateOfBirth.year;
            Console.WriteLine($"Na uctu {owner.name} ({age} let) je: {balance},-");
        }
        public void transferTo(Account account, int amount) {
            this.balance -= amount;
            account.balance += amount;
        }
        public override string ToString() {
            return $"Jmeno: {this.owner.name} (Rok nar. {this.owner.dateOfBirth.year}) \t Stav uctu: {balance},-";
        }
    }
    public class TestAccount {
        public static void Mainx() {
            //Date KarlovoNaroz = new Date(19, 4, 1964);
            //Date PavlovoNaroz = new Date(19,4,1950);
            Person o1 = new Person("Karel", new Date(19,4,1964));
            //Person o2 = new Person("Pavel", new Date(19, 4, 1950));
            //Account u1 = new Account(500, "Adam", 30);
            //Account u2 = new Account(300, "Eva", 30);
            //Account u3 = new Account();
            //Account u4 = new Account();
            Account u5 = new Account(100, o1);
            Account u6 = new Account(200, new Person("Pepa",new Date(20,4,1988)));
            Console.WriteLine("----------------");
            Console.WriteLine(o1.myAccounts[0]);
            Account u10 = new Account(200, o1);
            Account u11 = new Account(333, o1);
            Console.WriteLine("----------------");
            o1.writeAccounts();
            Console.WriteLine("----------------");
            Console.WriteLine(o1.ToString());
            Console.WriteLine("----------------");
            u5.writeBalance();
            Console.WriteLine(u5.owner.dateOfBirth.year);
            Console.WriteLine(u6.ToString());
            Console.WriteLine("----------------");
            Person pokus = new Person("Alice",1,2,1999);
            Console.WriteLine(o1.getAge());
            Console.WriteLine(u6.owner.getAge());
        }
    }
}


// Viasfora - barevne zavorky