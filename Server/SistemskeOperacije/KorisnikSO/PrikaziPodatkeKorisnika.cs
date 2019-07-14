using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.KorisnikSO
{
  public class PrikaziPodatkeKorisnika:OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Korisnik k = new Korisnik();
            k.IdKorisnika = Broker.DajSesiju().vratiSifru(k);
            Broker.DajSesiju().insert(k);
            return k;
        }
    }
}
