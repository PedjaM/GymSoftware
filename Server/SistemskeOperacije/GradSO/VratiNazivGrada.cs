using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.GradSO
{
    public class VratiNazivGrada : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {

            return Broker.DajSesiju().vratiJedanZaID(odo as OpstiDomenskiObjekat);
        }
    }
}
