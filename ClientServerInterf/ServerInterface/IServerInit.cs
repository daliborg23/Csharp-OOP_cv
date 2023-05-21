using ServerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServerInterface {
    public interface IServerInit {
        IServerAuth autorizuj(string jmeno, string heslo);
        IServerInit testSpojeni();
        IServerAuth odautorizuj(string jmeno);
    }
}
