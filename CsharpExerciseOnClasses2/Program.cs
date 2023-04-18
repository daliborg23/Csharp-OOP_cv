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
            Console.WriteLine("Zmena dne na 31. (ve 4. nesici neni)");
            mdTest.setDay(31);
            Console.WriteLine(mdTest);
            Console.WriteLine("Zmena dne na 30. (ve 4. nesici je)");
            mdTest.setDay(30);
            Console.WriteLine(mdTest);

        }
    }
}
