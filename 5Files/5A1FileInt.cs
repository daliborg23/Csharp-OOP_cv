using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5Files {
    public class _5A1FileInt {
        public static void Mainx() {
            string cesta = "C:\\Kurs\\BinarniSouborInt.dat";
            int[] poleProZapis = new int[] { 16, 7 };
            int[] poleProCteni = new int[2];
            int cislo = 0; int ii = 0;
            FileInfo fi = new FileInfo(cesta);
            if (fi.Directory.Exists) {
                using (FileStream fs = new FileStream(cesta, FileMode.Create)) {
                    using (BinaryWriter bw = new BinaryWriter(fs)) {
                        foreach (int i in poleProZapis) {
                            bw.Write(i);
                        }
                        fs.Seek(0, SeekOrigin.Begin);
                    }
                }
                using (FileStream fs = new FileStream(cesta, FileMode.Open)) {
                    using (BinaryReader br = new BinaryReader(fs)) { 
                        fs.Seek(0, SeekOrigin.Begin);
                        do {
                            try {
                                cislo = br.ReadInt32();
                                poleProCteni[ii] = cislo;
                                Console.WriteLine("Pozice v souboru: " + fs.Position + ", obsah: " + poleProCteni[ii]);
                                if (br.PeekChar() == (-1)) { throw new EndOfStreamException("Konec cteni souboru."); }
                                ii++;
                            }
                            catch (EndOfStreamException e) {
                                Console.WriteLine("[" + e.Message + "]\n[" + e.StackTrace + "]");
                                break;
                            }
                            //finally {
                            //    bw.Close(); br.Close(); fs.Close();
                            //}
                        } while (true);
                    }
                }
            }
            else {
                Console.WriteLine("Cesta " + fi.Directory + " neexistuje.");
            }
        }
    }
}
