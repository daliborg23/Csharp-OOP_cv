using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5Files {
    public class _4bA1FileByte {
        public static void Mainx() {
            string cesta = "C:\\Kurs\\BinarniSoubor.dat";
            byte[] poleProZapis = new byte[] { 16, 7 };
            byte[] poleProCteni = new byte[2];
            int cislo = 0; int ii = 0; int dny = 0; int hodiny = 0;
            FileInfo fi = new FileInfo(cesta);
            if (fi.Directory.Exists) {
                using (FileStream fs = new FileStream(cesta, FileMode.Create)) {
                    foreach (byte b in poleProZapis) {
                        fs.WriteByte(b);
                    }
                    fs.Seek(0, SeekOrigin.Begin);
                    do {
                        try {
                            cislo = fs.ReadByte();
                            if (cislo == -1) { throw new EndOfStreamException("Konec cteni souboru."); }
                            poleProCteni[ii] = (byte)cislo;
                            Console.WriteLine("Pozice v souboru: " + fs.Position + ", obsah: " + poleProCteni[ii]);
                            ii++;
                        }
                        catch (EndOfStreamException e) {
                            Console.WriteLine("[" + e.Message + "]\n["+ e.StackTrace + "]");
                            //throw;
                            break;
                        }
                        //finally { // zavre blok using
                        //    fs.Close();
                        //}
                    } while (true);
                    dny = poleProCteni[0];
                    hodiny = poleProCteni[1];
                    Console.WriteLine(dny + " dnu a " + hodiny + " hodiny je " + ((dny * 24) + hodiny) + " hodin");
                } 
            }
            else {
                Console.WriteLine("Cesta " + fi.Directory + " neexistuje.");
            }
        }
    }
}
