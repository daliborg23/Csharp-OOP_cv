using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("-----------------------Test-----------------------");
            MyDate mdTest = new(2023, 4, 18);
            Console.WriteLine($"{mdTest.getDayOfWeek(2023,4,16)}");
            Console.WriteLine(mdTest);
            mdTest.setDay(31);
            Console.WriteLine(mdTest);
            mdTest.setDay(30);
            Console.WriteLine(mdTest);

        }
    }
}
