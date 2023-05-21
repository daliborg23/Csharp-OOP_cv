using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerInterface;

namespace ServerLib {
    public class ServerAuth : MarshalByRefObject, IServerAuth {
        public int soucet(int a, int b) {
            if (a != 0) {
                //Console.WriteLine("Server pocita soucet cisel " + a + " + " + b);
                //return a + b;
                Console.WriteLine("Server pocita priklad " + a + " + 2 * " + b);
                return a + 2 * b;
            }
            else {
                Console.WriteLine("Uzivatel pozadal o odhlaseni.");
                return b;
            }
        }
    }
}