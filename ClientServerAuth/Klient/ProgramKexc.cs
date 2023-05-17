using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServerLib;

namespace Klient {
    public class ProgramKexc {
        private static ServerAuth objAuthField;
        private static ServerInit objInitField;
        public static void Main() {
            bool spojeni_ok;
            string loading = "";
            int i = 0;
            int srvPort = 1234;
            string kanalId = "kanal1";
            IChannel kanal = new TcpClientChannel();
            ChannelServices.RegisterChannel(kanal, false);

            string srvIP = "127.0.0.1";
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + kanalId;
            Console.Write("Pripojovani k: " + srvIP + ":" + srvPort);
            do {
                spojeni_ok = false;
                i++;
                try {
                    objInitField = (ServerInit)Activator.GetObject(typeof(ServerInit), srvAdr);
                    if (objInitField.testSpojeni() != null) {
                        spojeni_ok = true;
                        Console.Write("\n");
                        Console.WriteLine("Spojeni uspesne navazano. Na " + i + ". pokus.");
                    }
                }
                catch (System.Net.Sockets.SocketException e) {
                    loading = ".";
                    Console.Write(loading);
                    if (i % 3 == 0) {
                        Thread.Sleep(500);
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                        Console.Write("\b \b");
                    }
                    //throw;
                }
                Thread.Sleep(250);
            } while (!spojeni_ok);
            Console.WriteLine("klient bezi, pripojuje se na server: " + srvIP + ":" + srvPort);
            Console.WriteLine("----Login----"); // login / registrace?
            do {
                Console.Write("Username: ");
                string name = Console.ReadLine();
                Console.Write("Password: ");
                char[] psw = new char[20];
                int j;
                ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
                for (j = 0; j < psw.Length; j++) {
                    keyinfo = Console.ReadKey(true);
                    if (!keyinfo.Key.Equals(ConsoleKey.Enter)) {
                        psw[j] = keyinfo.KeyChar;
                        Console.Write("*");
                    }
                    else {
                        break;
                    }
                }
                string pwd = new string(psw);
                pwd = pwd.TrimEnd('\0');
                Console.WriteLine("\nZadane heslo: " + pwd);
                try {
                    objAuthField = objInitField.autorizuj(name, pwd);
                    if (objAuthField == null) {
                        throw new NullReferenceException();
                    }
                    //break;
                }
                catch (NullReferenceException e) {
                    Console.WriteLine("Ucet/heslo je spatne. " + e.Message);
                }
                Thread.Sleep(1000);
            } while (objAuthField == null);
            Console.WriteLine("Login OK");
            Console.WriteLine("===================================");

            Random r = new Random();

            //try {
            //    Console.WriteLine(objAuthField.soucet(r.Next(1, 1000001), r.Next(1, 1000001)));
            //    Thread.Sleep(10000); // System.Net.Sockets.SocketException pokud server spadne
            //    Console.WriteLine(objAuthField.soucet(r.Next(1, 1000001), r.Next(1, 1000001)));
            //    Thread.Sleep(10000);
            //    Console.WriteLine(objAuthField.soucet(r.Next(1, 1000001), r.Next(1, 1000001)));
            //}
            //catch (System.Net.Sockets.SocketException e) {
            //    Console.WriteLine("Spojeni preruseno " + e.Message);
            //    //throw;
            //}

            Console.WriteLine("Zadavejte cisla pro vypocet jejich souctu.");
            Console.WriteLine("Pokud zadate nulu do cisla 1, program konci.");
            int cislo1 = 0;
            int cislo2 = 0;
            do {
                try {
                    Console.Write("Cislo 1 = ");
                    bool isNumber = Int32.TryParse(Console.ReadLine(),out cislo1);
                    if (!isNumber) {
                        throw new InvalidCastException();
                    }
                    Console.Write("Cislo 2 = ");
                    isNumber = Int32.TryParse(Console.ReadLine(), out cislo2);
                    if (!isNumber) {
                        throw new InvalidCastException();
                    }
                    if (cislo1 != 0) {
                        Console.WriteLine("" + cislo1 + " + " + cislo2 + " = " + objAuthField.soucet(cislo1, cislo2));
                    }
                }
                catch (System.Net.Sockets.SocketException e) {
                    Console.WriteLine("Spojeni preruseno " + e.Message);
                }
                catch (InvalidCastException e) {
                    Console.WriteLine("Zadana hodnota nelze prevezt na cislo. " + e.Message);
                }
                //finally {
                //    cislo1 = 1;
                //}

            } while (cislo1 != 0);

            Console.WriteLine("Odhlasit? Ano");
            Console.ReadKey();
            objAuthField = objInitField.odautorizuj("test");

            //objAuth = null; // odhlaseni, spis by se mozna hodilo zrusit obejkt na strane serveru?
            //Console.WriteLine(objAuth.soucet(1, 1)); =nullref
            try {
                Console.WriteLine(objAuthField.soucet(1, 1));
            }
            catch (NullReferenceException e) {
                Console.WriteLine("Jste odhlaseni, nemuzete pocitat... \n" + e.Message + "\n" + e.StackTrace);
                //throw;
            }

            Console.ReadKey();
        }
    }
}
