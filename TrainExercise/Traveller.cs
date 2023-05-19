using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Traveller : Person {
        public enum EDiscount {
            Normal = 100, Student = 50, Pensioner = 25,  Employee = 0
        }
        public EDiscount discount;
        public int cardNumber;
        public static int cardId = 614136;
        public static int CardCount = 0;

        public Traveller(string firstname, string lastname,int num=100) : base(firstname,lastname) {
            this.cardNumber = cardId;
            this.discount = (EDiscount)num;
            cardId++;
            CardCount++;
        }
        public override string ToString() {
            return "Card number: " + cardNumber + base.ToString();
        }
        public static int Count() {
            return CardCount;
        }
    }
}
