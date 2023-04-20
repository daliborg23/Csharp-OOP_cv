using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
    abstract class Employee : Person {
        private int salary;
        public Employee() {
        }
        public Employee(int age, int salary) : base(age) {
            this.salary = salary;
        }
        public override void writeInfo() {
            //base.writeInfo();
            Console.Write("Pocet osob: " + Person.getCount() + ", vek: " + age);
            Console.Write(", Plat: " + salary);
        }
    }
}
