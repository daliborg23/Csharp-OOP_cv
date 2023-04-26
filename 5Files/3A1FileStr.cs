using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
//Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek může být reálné číslo)
namespace _5Files {
    class A1 {
        public static void Mainx() {
            int dny;
            int hodiny;

            Console.Write("Zadejte pocet dnu: ");
            dny = int.Parse(Console.ReadLine());
            Console.Write("Zadejte pocet hodin: ");
            hodiny = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} dnu a {1} hodiny je {2} hodin\n", dny, hodiny, (dny * 24) + hodiny);
            Console.WriteLine("\n" + dny + " dnu a " + hodiny + "hodiny je " + (dny * 24) + hodiny + " hodin\n"); //druhá možnost
        }
    }
    public class A1FileStr {
        public static void Mainx() {
            int dny;
            int hodiny;
            int sekundy;
            dny = 0; hodiny = 0; sekundy = 0;
            string cesta = "C:\\Kurs\\soubor7.txt";  // "5 dni 7 hodin"  "][[-;]\';./'/'\+_=-"
            string cesta2 = "C:\\Kurs\\soubor8.txt";

            FileInfo fi = new FileInfo(cesta);
            if (fi.Exists) { //  1==1 pro kontrolu na zmenu nazvu souboru
                try {
                    //StreamReader vstup = new StreamReader(cesta);
                    //string dnyHodniny = vstup.ReadToEnd();
                    //string[] numbers = Regex.Split(dnyHodniny, @"\D+");
                    //foreach (string value in numbers) {
                    //    if (!string.IsNullOrEmpty(value)) {
                    //        dny = int.Parse(numbers[0]);
                    //        hodiny = int.Parse(numbers[1]);
                    //    }
                    //}

                    //// 2. varianta aby string nesel prevezt na cislo
                    //StreamReader vstup = new StreamReader(cesta);
                    //string dnyHodniny = vstup.ReadToEnd();
                    //string[] lines = dnyHodniny.Split(new char[] {'\n'});
                    //int count = lines.Length;
                    //bool prvni = int.TryParse(lines[0], out dny);
                    //if (!prvni) Console.WriteLine("Dny nelze prevezt.");
                    //bool druhy = int.TryParse(lines[1], out hodiny);
                    //if (!druhy) Console.WriteLine("Hodiny nelze prevezt.");

                    // 3. varianta jen s parse
                    StreamReader vstup = new StreamReader(cesta); 
                    string dnyHodniny = vstup.ReadToEnd();
                    string[] lines = dnyHodniny.Split(new char[] { '\n' });
                    int count = lines.Length;
                    try {
                        dny = int.Parse(lines[0]);
                        hodiny = int.Parse(lines[1]);
                        //sekundy = int.Parse(lines[2]); // cteni za koncem souboru?
                    }
                    catch (FormatException e) {
                        Console.WriteLine("Spatne zadane hodnoty. ");
                        //throw;
                    }
                    catch (IndexOutOfRangeException e) {
                        Console.WriteLine("Pokus o cteni tretiho radku ktery neni.");
                    }
                    catch (Exception e) {
                        Console.WriteLine("Nejaka dalsi vyjimka?\n" + e.Message + "\n" + e.StackTrace);
                    }
                }
                catch (FileNotFoundException e) { // problem az za behu
                    Console.WriteLine("Soubor neexistuje. " + e.Message);
                    //throw;
                }
            }
            else {
                Console.WriteLine("Soubor " + cesta + " neexistuje.");
            }
            FileInfo fi2 = new FileInfo(cesta2);
            if (fi2.Exists) {
                StreamWriter vystup = new StreamWriter(cesta2,true); // // 2. parametr konstruktoru true = prida radek, false = prepise 
                vystup.WriteLine((dny + " dnu a " + hodiny + " hodiny je " + ((dny * 24) + hodiny) + " hodin"));
                vystup.Close(); // kdyz nezavru, tak se soubor neulozi.
            }
            else {
                Console.WriteLine("Soubor " + cesta + " neexistuje.");
            }
            Console.WriteLine("{0} dnu a {1} hodiny je {2} hodin", dny, hodiny, ((dny * 24) + hodiny));
            //Console.WriteLine(dny + " dnu a " + hodiny + " hodiny je " + ((dny * 24) + hodiny) + " hodin");
        }
    }
}