using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine();
        }
    }
}
