using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("-----------------------MyDate-----------------------");
            //Console.WriteLine("-----------------------Test-----------------------");
            //MyDate mdTest = new(2012, 2, 29);
            //Console.WriteLine(mdTest);
            //Console.WriteLine(mdTest.nextYear());
            //Console.Write($"{mdTest.getDayOfWeek(2023, 4, 19)}");
            //Console.WriteLine(" = 3");
            //Console.WriteLine(mdTest);
            //Console.WriteLine("Zmena dne na 31. (ve 2. mesici neni)");
            //mdTest.setDay(31);
            //Console.WriteLine(mdTest);
            //Console.WriteLine("Zmena dne na 28. (ve 2. mesici je)");
            //mdTest.setDay(28);
            //Console.WriteLine(mdTest);
            //#region DoKonceSichty
            //DateTime casTed = DateTime.Now;
            //DateTime fajront = DateTime.Parse("22:00:00");
            //Console.WriteLine($"{casTed.ToShortTimeString()}  {fajront.ToShortTimeString()}     Do Konce sichty zbyva: {Math.Round((fajront - casTed).TotalSeconds, 2)} sekund");
            //#endregion
            MyDate mdTest1 = new(2012, 2, 28);
            Console.WriteLine(mdTest1);
            Console.WriteLine(mdTest1.nextDay());
            Console.WriteLine(mdTest1.nextDay());
            Console.WriteLine(mdTest1.nextMonth());
            Console.WriteLine(mdTest1.nextYear());
            Console.WriteLine();
            MyDate mdTest2 = new(2012, 1, 2);
            Console.WriteLine(mdTest2);
            Console.WriteLine(mdTest2.previousDay());
            Console.WriteLine(mdTest2.previousDay());
            Console.WriteLine(mdTest2.previousMonth());
            Console.WriteLine(mdTest2.previousYear());
            Console.WriteLine();
            MyDate mdTest3 = new (2012, 2, 29);
            Console.WriteLine(mdTest3.previousYear());
            Console.WriteLine();
            MyDate d4 = new MyDate(2099, 11, 31); // Invalid year, month, or day!
            MyDate d5 = new MyDate(2011, 2, 29);  // Invalid year, month, or day!
            Console.WriteLine();
            string YesNo = String.Empty;
            do {
                Console.WriteLine("Loop through dates from 28/12/2011 to 2/3/2012? y/n");
                YesNo = Console.ReadLine();
            } while (YesNo != "y" && YesNo != "n");
            if (YesNo == "y") { 
                MyDate mdOd = new(2011,12,27);
                MyDate mdDo = new(2012, 3, 2);
                int vysl = 1;
                do {
                    Console.WriteLine($"{mdOd.nextDay()}");
                    vysl = String.Compare(mdOd.ToString(), mdDo.ToString()); // asi neni nejidealnejsi
                } while (vysl != 0); //mozna porovnat dohromady rok, mesic a den
            } else {
                Console.WriteLine("Tak treba jindy.");
            }
            ////////////////////////////////////////////////////////////////
        }
    }
}
