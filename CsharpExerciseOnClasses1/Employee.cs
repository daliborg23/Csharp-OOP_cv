using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class Employee {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;
        //public Employee() {}
        public Employee(int id, string firstName, string lastName, int salary) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public int getID() { return id; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getName() { 
            return $"{firstName} {lastName}";
        }
        public int getSalary() { return salary; }
        public void setSalary(int salary) {  this.salary = salary; }
        public int getAnnualSalary() {
            return salary * 12;
        }
        public int raiseSalary(int percent) {
            salary += salary * percent / 100;
            return salary;
        }
        public override string ToString() {
            return $"Employee[id={id},name={getName()},salary={salary}]";
        }
    }
}
