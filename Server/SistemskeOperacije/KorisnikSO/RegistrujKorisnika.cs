using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.KorisnikSO
{
    public class RegistrujKorisnika:OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Korisnik k = odo as Korisnik;
            k.IdKorisnika = Broker.DajSesiju().vratiSifru(k);
            int rez = Broker.DajSesiju().insert(k);
            if(rez != 0)
            {
                return k;
            }
            else
            {
                return null;
            }
 
        }
    }
}

