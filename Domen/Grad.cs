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
    public class Grad : OpstiDomenskiObjekat
    {
        int idGrada;
        string naziv;
        string postanskiBroj;

        public int IdGrada { get => idGrada; set => idGrada = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }


        #region Opsti domenski objekat

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Grad";
            }
        }

        public string Uslovi;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return Uslovi;
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(IDGrada) VALUES (" + IdGrada + ")";
            }
        }

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "IDGrada";
            }
        }

        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "IDGrada=" + IdGrada;
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return " IDGrada=" + IdGrada + ", Naziv='" + Naziv + "', PostanskiBroj='" +
                    PostanskiBroj + "'";
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
            Grad g = new Grad();
            g.IdGrada = Convert.ToInt32(red["IDGrada"]);
            g.Naziv = red["Naziv"].ToString();
            g.PostanskiBroj = red["PostanskiBroj"].ToString();

            return g;
        }


        #endregion ODO
    }
}
