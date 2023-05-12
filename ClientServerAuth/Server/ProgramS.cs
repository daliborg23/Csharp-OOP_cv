using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ServerLib;

namespace Server {
    public class ProgramS {
        static void Main() {
            int srvPort = 1234;
            string kanalId = "kanal1";
            IChannel kanal = new TcpServerChannel(srvPort);
            ChannelServices.RegisterChannel(kanal, false);
            ServerInit objInit = new ServerInit();
            RemotingServices.Marshal(objInit, kanalId);
            Console.WriteLine("server bezi na portu: " + srvPort);
            while (true) { System.Threading.Thread.Sleep(1000); }
        }
    }
}
