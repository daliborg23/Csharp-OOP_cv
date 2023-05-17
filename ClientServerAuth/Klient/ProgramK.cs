using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ServerLib;

namespace Klient {
    public class ProgramK {
        public static void Mainx() {
            int srvPort = 1234;
            string kanalId = "kanal1";
            IChannel kanal = new TcpClientChannel();
            ChannelServices.RegisterChannel(kanal, false);

            string srvIP = "127.0.0.1";
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + kanalId;

            ServerInit objInit = (ServerInit)Activator.GetObject(typeof(ServerInit), srvAdr);

            Console.WriteLine("klient bezi, pripojuje se na server: " + srvIP + ":" + srvPort);
            Console.WriteLine("Zadejte jmeno a heslo");
            Console.ReadKey();

            ServerAuth objAuth = objInit.autorizuj("test", "test");

            Random r = new Random();
            Console.WriteLine(objAuth.soucet(r.Next(1,1000001), r.Next(1, 1000001)));
            Console.WriteLine(objAuth.soucet(r.Next(1,1000001), r.Next(1, 1000001)));
            Console.WriteLine(objAuth.soucet(r.Next(1,1000001), r.Next(1, 1000001)));

            Console.WriteLine("Odhlasit? Ano");
            objAuth = objInit.odautorizuj("test");

            //objAuth = null; // odhlaseni, spis by se mozna hodilo zrusit obejkt na strane serveru?
            //Console.WriteLine(objAuth.soucet(1, 1)); =nullref
            try {
                Console.WriteLine(objAuth.soucet(1, 1));
            }
            catch (NullReferenceException e) {
                Console.WriteLine("Jste odhlaseni, nemuzete pocitat... \n" + e.Message + "\n" + e.StackTrace);
                //throw;
            }

            Console.ReadKey();
        }
    }
}
