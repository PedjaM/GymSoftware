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
    public class Istorija : OpstiDomenskiObjekat
    {

        int idKorisnika;
        int idPaketa;
        DateTime datumUplate;
        DateTime datumPocetka;
        DateTime datumZavrsetka;

        [Browsable(false)]
        public int IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public int IdPaketa { get => idPaketa; set => idPaketa = value; }
        [Browsable(false)]
        public DateTime DatumUplate { get => datumUplate; set => datumUplate = value; }
        [DisplayName("Datum početka")]
        public DateTime DatumPocetka { get => datumPocetka; set => datumPocetka = value; }
        [DisplayName("Datum završetka")]
        public DateTime DatumZavrsetka { get => datumZavrsetka; set => datumZavrsetka = value; }


        #region OpstiDomenskiObjekat

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Istorija";
            }
        }

        public string Uslovi;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return "IDKorisnika=" + IdKorisnika;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "VALUES (" + IdKorisnika + ", " + IdPaketa + ", '" + DatumUplate.ToString("yyyyMMdd") +
                    "', '" + datumPocetka.ToString("yyyyMMdd") + "', '" + datumZavrsetka.ToString("yyyyMMdd") +"')";
            
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "IDKorisnika";
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
                return " IDKorisnika=" + IdKorisnika + ",IDPaketa=" + IdPaketa +
               ",DatumUplate='" + DatumUplate.ToString("yyyyMMdd")
              + "',DatumPocetka='" + datumPocetka.ToString("yyyyMMdd") +
              "',DatumZavrsetka='" + datumZavrsetka.ToString("yyyyMMdd") + "'";
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

            Istorija i = new Istorija();
            i.IdKorisnika = Convert.ToInt32(red["IDKorisnika"]);
            i.IdPaketa = Convert.ToInt32(red["IDPaketa"]);
            i.DatumUplate = Convert.ToDateTime(red["DatumUplate"]);
            i.DatumPocetka = Convert.ToDateTime(red["DatumPocetka"]);
            i.DatumZavrsetka = Convert.ToDateTime(red["DatumZavrsetka"]);

            return i;
        }


        #endregion ODO



    }
}

