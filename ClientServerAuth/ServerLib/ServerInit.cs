using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerLib {
    public class ServerInit : MarshalByRefObject {
        private ServerAuth overeni;
        private List<string> accounts = new List<string>{ "test", "ucet1" };
        private List<string> passwords = new List<string> { "test", "hesl" };
        public ServerAuth autorizuj(string jmeno, string heslo) { // jak vratit nejakou odpoved ze je neco spatne..., registraci se prida acc a pw do listu
            bool loginOk;
            int i = 0;
            do {
                if (jmeno == accounts[i]) {
                    if (heslo == passwords[i]) {
                        Console.WriteLine("pripojil se uzivatel: " + jmeno);
                        return overeni = new ServerAuth();
                    }
                    // spatne heslo
                }
                //spatny ucet
                i++;
            } while (i < accounts.Count());
            return overeni = null;
        }
        public ServerInit testSpojeni() { //dispose ?
            return this;
        }
        public ServerAuth odautorizuj(string jmeno) {
            Console.WriteLine("odhlasil se uzivatel: " + jmeno);
            return overeni = null;
        }
    }
}