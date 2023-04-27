using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition {
    class SpatnyPrumerException : Exception {
        public SpatnyPrumerException(string s) : base(s) {

        }
    }
    public class Student {
        private string firstName;
        private string lastName;
        private double age;
        private double average;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Age { get => age; set => age = value; }
        public double Average { get => average; set => average = value; }

        public Student(string firstName, string lastName, double age, double average) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Average = average;
        }
        public override string ToString() {
            return $"| Name: {FirstName,-8} {LastName,-8} | Age: {Age,2} | Average: {Average,5} |";
        }
        public void Zkouska(double znamka) { 
            average = Math.Round((average + znamka) / 2.00,2);
            if (average > 4.00) {
                Console.WriteLine(FirstName + " " + LastName + " prumer znakem: " + average);
                throw new SpatnyPrumerException("Spatny prumer. ");
            }
        }

    }
}
