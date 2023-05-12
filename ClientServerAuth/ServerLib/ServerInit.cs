using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib {
    public class ServerInit : MarshalByRefObject {
        public ServerAuth overeni; // asi private
        public ServerAuth autorizuj(string jmeno, string heslo) {
            if (jmeno == "test" && heslo == "test") {
                Console.WriteLine("pripojil se uzivatel: " + jmeno);
                return overeni = new ServerAuth();

            } else {
                return overeni = null;
            }
        }
        public ServerAuth odautorizuj(string jmeno) {
            Console.WriteLine("odhlasil se uzivatel: " + jmeno);
            return overeni = null;
        }
    }
}