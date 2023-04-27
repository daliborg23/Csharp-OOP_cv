using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition {
    public class Teacher {
        private string firstName;
        private string lastName;
        private double age;
        private int salary;
        private int pupilsInClass;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
        public int PupilsInClass { get => pupilsInClass; set => pupilsInClass = value; }
        public string FullName() {
            return FirstName + " " + LastName;
        }
        public Teacher(string firstName, string lastName, double age) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = 15000; // zaklad
        }
        public void salaryBonus() {
            Salary += (Salary * PupilsInClass * 5) / 100;
            Console.WriteLine("Salary Bonus: " + Salary);
        }
    }
}
