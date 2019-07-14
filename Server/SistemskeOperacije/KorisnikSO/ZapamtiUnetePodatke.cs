using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.KorisnikSO
{
    public class ZapamtiUnetePodatke : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.DajSesiju().update(odo as OpstiDomenskiObjekat);
        }
    }
}
