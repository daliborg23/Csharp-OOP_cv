using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class Account {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name) {
            this.id = id;
            this.name = name;
        }
        public Account(string id, string name, int balance) {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID() {
            return this.id;
        }
        public string getName() {
            return this.name;
        }
        public int getBalance() {
            return this.balance;
        }
        public int credit(int amount) {
            return this.balance+=amount;
        }
        public int debit(int amount) {
            if (amount <= balance) {
                balance -= amount;
            } else {
                Console.WriteLine("Amount exceeded balance");
            }
            return balance;
        }
        public int transferTo(Account another, int amount) {
            if (amount <= balance) {
                this.balance -= amount;
                another.balance += amount;
            } else {
                Console.WriteLine("Amount exceeded balance");
            }
            return balance;
        }
        public override string ToString() {
            return $"Account[id={id},name={name},balance={balance}]";
        }
    }
}
