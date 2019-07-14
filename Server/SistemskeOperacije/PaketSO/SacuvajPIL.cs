using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.PaketSO
{
    public class SacuvajPIL : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            List<int> rez = new List<int>();
            List<Object> listaPIL = odo as List<Object>;
            Paket p = listaPIL[0] as Paket;
           rez.Add(Broker.DajSesiju().insert(p as OpstiDomenskiObjekat));
            Domen.Istorija i = listaPIL[1] as Domen.Istorija;
           rez.Add(Broker.DajSesiju().insert(i as OpstiDomenskiObjekat));
            List<PaketAkt> listaPA = listaPIL[2] as List<PaketAkt>;
            foreach(PaketAkt pa in listaPA)
            {
                rez.Add(Broker.DajSesiju().insert(pa as OpstiDomenskiObjekat));
            }

            foreach(int br in rez)
            {
                if (br == 0) return 0;
            }
            return 1;
        }
    }
}
