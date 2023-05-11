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
        public static void Main() {
            int srvPort = 1234;
            string kanalId = "kanal1";
            IChannel kanal = new TcpClientChannel();
            ChannelServices.RegisterChannel(kanal, false);

            string srvIP = "127.0.0.1";
            string srvAdr = "tcp://" + srvIP + ":" + srvPort + "/" + kanalId;

            ServerClass obj = (ServerClass)Activator.GetObject(typeof(ServerClass), srvAdr);

            Console.WriteLine("klient bezi, pripojuje se na server: " + srvIP + ":" + srvPort);
            Console.WriteLine("6 + 7 = " + obj.soucet(6, 7));

            Console.ReadKey();
        }
    }
}
