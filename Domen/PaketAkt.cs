using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class PaketAkt : OpstiDomenskiObjekat
    {
        int idPaketa;
        int idAktivnosti;

        public int IdPaketa { get => idPaketa; set => idPaketa = value; }
        public int IdAktivnosti { get => idAktivnosti; set => idAktivnosti = value; }

        #region OpstiDomenskiObjekat

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "PaketAkt";
            }
        }

        public string Uslovi;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return "IDPaket = " + idPaketa;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " VALUES (" + IdPaketa + ", " + IdAktivnosti + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "IDPaket";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "IDPaket=" + IdPaketa;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return "IDPaket=" + IdPaketa + ",IDAktivnost=" + IdAktivnosti;
            }
        }

        [Browsable(false)]
        public string NazivJoin
        {
            get
            {
                return "PaketAkt join Aktivnost on PaketAkt.IDAktivnost = Aktivnost.IDAktivnosti";
            }
        }


        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            PaketAkt pa = new PaketAkt();
            pa.IdPaketa = Convert.ToInt32(red["IDPaket"]);
            pa.IdAktivnosti = Convert.ToInt32(red["IDAktivnost"]);
            return pa;
        }


        #endregion ODO
    }
}
