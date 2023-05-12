using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib {
    public class ServerAuth : MarshalByRefObject {
        public int soucet(int a, int b) {
            Console.WriteLine("Server pocita soucet cisel " + a + " + " + b);
            return a + b;
        }
    }
}