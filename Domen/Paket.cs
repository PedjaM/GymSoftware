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
    public class Paket : OpstiDomenskiObjekat
    {
        int idPaketa;
        double ukupnaCena;

        public int IdPaketa { get => idPaketa; set => idPaketa = value; }
        public double UkupnaCena { get => ukupnaCena; set => ukupnaCena = value; }


        #region OpstiDomenskiObjekat
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Paket";
            }
        }

        public string Uslovi;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return "IDPaketa = " +  IdPaketa;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " VALUES (" + IdPaketa + ", " + ukupnaCena + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "IDPaketa";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "IDPaketa=" + IdPaketa;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " IDPaketa=" + IdPaketa + ",UkupnaCena=" + UkupnaCena;
            }
        }

        [Browsable(false)]
        public string NazivJoin
        {
            get
            {
                return "";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Paket p = new Paket();
            p.IdPaketa = Convert.ToInt32(red["IDPaketa"]);
            p.UkupnaCena = Convert.ToDouble(red["UkupnaCena"]);

            return p;
        }


        #endregion ODO
    }
}
