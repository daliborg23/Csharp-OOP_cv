using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
    abstract class Person {
        public int age;
        private static int count;
        public Person() {
            count++;
        }
        public Person(int age) {
            this.age = age;
            count++;
        }
        public static int getCount() {
            return count;
        }
        public abstract void writeInfo();
        public override string ToString() {
            return "ToString: pocet osob: " + Person.getCount() + ", vek: " + age;
        }
        //    {
        //      base.writeInfo();
        //    Console.WriteLine("Vek: " + age + "     Pocet instanci: " + getCount() + "      Vek getterem: " + getAge());
        //}
    }
}
