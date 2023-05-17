using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib {
    public class ServerAuth : MarshalByRefObject {
        public int soucet(int a, int b) {
            if (a != 0) {
                Console.WriteLine("Server pocita soucet cisel " + a + " + " + b);
                return a + b;
            } else {
                Console.WriteLine("Uzivatel pozadal o odhlaseni.");
                return b;
            }
        }
    }
}