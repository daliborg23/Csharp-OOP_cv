using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12
{
    internal class Traveller : Person {
        public enum EDiscount {
            Student = 50, Pensioner = 25, Normal = 100, Employee = 0
        }
        public EDiscount discount;
        public int cardNumber;

        public Traveller(int age, int cardnumber, EDiscount discount) : base (age) {
            this.cardNumber = cardnumber;
            this.discount = discount;
            
        }
        public override void writeInfo() {
            throw new NotImplementedException();
        }
    }
}
