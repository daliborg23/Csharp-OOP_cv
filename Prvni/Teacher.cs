using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
    class Teacher : Employee {
        private int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            this.teachingTime = teachingTime;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Oduceny cas: " + teachingTime);
        }
    }
}
