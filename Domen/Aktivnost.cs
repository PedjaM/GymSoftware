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
    public class Aktivnost:OpstiDomenskiObjekat
    {
        int rbAktivnosti;
        string naziv;
        double cena;

        public override string ToString()
        {
            return naziv;
        }

        public int RbAktivnosti { get => rbAktivnosti; set => rbAktivnosti = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }


        #region OpstiDomenskiObjekat
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Aktivnost";
            }
        }

        public string Uslovi;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return "Naziv = '" + naziv + "'";
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(IDAktivnosti) VALUES (" + RbAktivnosti + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "IDAktivnosti";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "IDAktivnosti=" + RbAktivnosti;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " IDAktivnosti=" + RbAktivnosti + ",Naziv= '" + Naziv + "', Cena = " + Cena;
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
            Aktivnost a = new Aktivnost();
            a.RbAktivnosti = Convert.ToInt32(red["IDAktivnosti"]);
            a.Naziv = red["Naziv"].ToString();
            a.Cena = Convert.ToDouble(red["Cena"]);
            return a;
        }

        #endregion
    }
}
