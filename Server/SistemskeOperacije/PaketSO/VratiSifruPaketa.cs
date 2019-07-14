using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.PaketSO
{
    public class VratiSifruPaketa : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
      
            return Broker.DajSesiju().vratiSifru(odo as OpstiDomenskiObjekat);
        }
    }
}
