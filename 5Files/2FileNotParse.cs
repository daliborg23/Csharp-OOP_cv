using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Files {
    internal class _2FileNotParse {
        public static void Mainx() {
            List<string> listText = new List<string>() { 
                "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                "Integer malesuada. Donec iaculis gravida nulla.",
                "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                "Nunc auctor. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna."
            };
            string cesta = "C:\\Kurs\\Soubor6.txt";
            FileInfo fileInfo = new FileInfo(cesta);
            if (fileInfo.Directory.Exists) {
                File.WriteAllLines(cesta, listText);
                List<string> listPrecteni = new List<string>(File.ReadAllLines(cesta));
                foreach (string radek in listPrecteni) {
                    Console.WriteLine(radek);
                }
            }
            else {
                Console.WriteLine("Cesta " + fileInfo.Directory + " neexistuje.");
            }

        }
    }
}
