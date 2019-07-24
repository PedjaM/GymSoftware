using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.PaketSO
{
    public class VratiAktivnostiPaketa : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            Paket p = (Paket)odo;
            PaketAkt pa = new PaketAkt { IdPaketa = p.IdPaketa };
            pa.Uslovi = $"WHERE IdPaket = {pa.IdPaketa}";
            //vraca sve paket aktivnosti
            List<PaketAkt> paketAktivnosti = Broker.DajSesiju().vratiSveZaOpstiUslov(pa).OfType<PaketAkt>().ToList();

            List<Aktivnost> aktivnosti = new List<Aktivnost>();

            //za svaku paket aktivnost vrati aktivnost
            foreach (PaketAkt paketAkt in paketAktivnosti)
            {
                //poziva vrati jedan za id, gde se prosledjuje aktivnost sa id-em koju ima paketAkt
                aktivnosti.Add((Aktivnost)Broker.DajSesiju().vratiJedanZaID(new Aktivnost { RbAktivnosti = paketAkt.IdAktivnosti }));
            }

            /*
             u klasi paket trebalo bi da imas listu aktivnosti za taj paket
             dodaj property List<Aktivnost> aktivnost u klasi Paket.
             Tako da mozes da, kada vratis aktivnosti za paket,
             samo ih dodas paketu i na kraju vratis ceo paket sa aktivnostima
                    p.Aktivnosti = aktivnosti;
             
             */

            return aktivnosti;
        }
    }
}
