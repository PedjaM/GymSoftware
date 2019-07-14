using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.AktivnostSO
{
    public class VratiSifruAktivnosti : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {

            return Broker.DajSesiju().vratiSifruZaNaziv(odo as OpstiDomenskiObjekat);
        }
    }
}
