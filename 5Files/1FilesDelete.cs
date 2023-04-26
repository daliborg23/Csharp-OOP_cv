using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Files {
    public class _1FilesDelete {
        public static void Mainx() {
            string cesta = "C:\\Kurs\\";
            string soubor = "1Pokus.txt";
            File.Create(cesta + soubor).Dispose(); // novy pokusny soubor
            Console.WriteLine(cesta + soubor);
            //Console.WriteLine(File.Exists(cesta));
            //Console.WriteLine(File.Exists(cesta + "\\1Pokus.txt"));
            DirectoryInfo di = new DirectoryInfo(cesta);
            if (di.Exists) {
                Console.WriteLine("Adresar {0} ma {1} souboru", cesta, di.GetFiles().Length);
                foreach (FileInfo fi in di.GetFiles()) {
                    Console.WriteLine(fi.FullName + "\t" + fi.Length);
                }
            }
            else {
                Console.WriteLine("Zadana cesta " + cesta + " neexistuje.");
            }
            Console.WriteLine("Ktery soubor smazat?");
            string KeSmazani = Console.ReadLine();
            FileInfo fiDelete = new FileInfo(cesta + KeSmazani);
            if (File.Exists(cesta + KeSmazani)) {
                Console.WriteLine("Opravdu chcete smazat soubor " + cesta + KeSmazani + "? y/n");
                string YesNo = Console.ReadLine();
                if (YesNo == "y") {
                    //File.Delete(cesta + KeSmazani); //
                    fiDelete.Delete();
                    Console.WriteLine("Soubor " + cesta + KeSmazani + " uspesne smazan.");
                }
                else if (YesNo == "n") {
                    Console.WriteLine("Tak nic.");
                }
                else {
                    Console.WriteLine("Otazka znela jestli chces smazat soubor a spravna odpoved je 'y' pro Ano nebo 'n' pro Ne...");
                }
            }
            else {
                Console.WriteLine("Zadany soubor " + cesta + KeSmazani + " neexistuje.");
            }
            Console.WriteLine();
            if (di.Exists) {
                Console.WriteLine("Adresar {0} ma {1} souboru", cesta, di.GetFiles().Length);
                foreach (FileInfo fi in di.GetFiles()) {
                    Console.WriteLine(fi.FullName);
                }
            }
            else {
                Console.WriteLine("Zadana cesta " + cesta + " neexistuje.");
            }
        }
    }
}
