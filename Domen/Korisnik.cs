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
    public class Korisnik : OpstiDomenskiObjekat
    {
        int idKorisnika;
        string ime;
        string prezime;
        int godiste;
        string pol;
        Grad grad;

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public int IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Pol { get => pol; set => pol = value; }
        public Grad Grad { get => grad; set => grad = value; }

        #region OpstiDomenskiObjekat

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Korisnik";
            }
        }

        public string Uslovi;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return "IDKorisnika = " + IdKorisnika;
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
        public string Insert
        {
            get
            {
                return " values (" + idKorisnika + ", '" + ime + "', '" + prezime +
                    "', " + godiste + ", '" + pol + "', " + Grad.IdGrada + ")";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "IDKorisnika=" + idKorisnika;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return "IDKorisnika=" + idKorisnika + ",Ime='" + ime + "', Prezime='" +
               prezime + "',Godiste=" + godiste + ",Pol='" + pol + "', IDGrad=" + grad.IdGrada;
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
            Korisnik k = new Korisnik();
            k.IdKorisnika = Convert.ToInt32(red["IDKorisnika"]);
            k.Ime = red["Ime"].ToString();
            k.Prezime = red["Prezime"].ToString();

            k.Godiste = Convert.ToInt32(red["Godiste"]);
            k.Pol = red["Pol"].ToString();
            k.grad = new Grad();
            k.grad.IdGrada = Convert.ToInt32(red["IDGrad"]);

            return k;
        }

        #endregion
    }
}
