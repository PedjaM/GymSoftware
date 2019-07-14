using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.Istorija
{
    public class VratiListuIstorija : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.DajSesiju().vratiSveZaOpstiUslov(odo as OpstiDomenskiObjekat);
        }
    }
}
