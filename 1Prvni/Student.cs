using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
    class Student : Person {
        public int scholarship;
        public Student() { }
        public Student(int age, int scholarship) : base(age) {
            this.scholarship = scholarship;
        }
        public override void writeInfo() {
            //base.writeInfo();
            Console.Write("Pocet osob: " + Person.getCount() + ", vek: " + age);
            Console.WriteLine(", Stipendium: " + scholarship);
        }
        public string toString() {
            return base.ToString() + String.Format(" Stipendium: " + scholarship);
        }
    }
}
