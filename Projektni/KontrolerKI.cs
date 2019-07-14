using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektni
{
    public class KontrolerKI
    {
        static Komunikacija k;

      public static bool PoveziSeNaServer()
        {
            k = new Komunikacija();
            if (k.PoveziSeNaServer())
            {
                return true;
            }
            else return false;
        }
       
        public static void Kraj()
        {
            k.Kraj();
     
        }

        public static Korisnik PrijaviKorisnika(Korisnik ko)
        {
            return k.Login(ko);
        }

        public static List<Grad> VratiSveGradove()
        {
            List<Grad> listaGradova = new List<Grad>();
            List<OpstiDomenskiObjekat> lodo = k.VratiSveGradove();
            foreach (OpstiDomenskiObjekat odo in lodo)
            {
                Grad g = new Grad();
                g = odo as Grad;
                listaGradova.Add(g);
            }
            return listaGradova;
        }

        public static Korisnik RegistrujKorisnika(Korisnik ko)
        {
            return k.RegistrujKorisnika(ko);
        }

        public static string VratiNazivGrada(Korisnik k1)
        {
            Grad g = new Grad();
            g.IdGrada = k1.Grad.IdGrada;
            g = k.VratiNazivGrad(g);
            return g.Naziv;
        }

        public static bool ZapamtiUnetePodatke(Korisnik k1)
        {
            int temp = k.IzmeniProfilKorisnika(k1);
            if (temp == 0) return false;
            else return true;
        }

        public static bool ObrisiProfil(Korisnik k1)
        {
            int temp = k.ObrisiKorisnika(k1);
            if (temp == 0) return false;
            else return true;

        }

        public static List<Aktivnost> UcitajListuAktivnosti()
        {
            List<Aktivnost> la = new List<Aktivnost>();
            List<OpstiDomenskiObjekat> lodo = k.VratiListuAktivnosti();
            foreach (OpstiDomenskiObjekat odo in lodo)
            {
                Aktivnost a = new Aktivnost();
                a = odo as Aktivnost;
                la.Add(a);
            }
            return la;
        }

        public static Paket VratiPaket()
        {
            Paket p = new Paket();
            p.IdPaketa = k.VratiSifruPaketa();
            return p;
        }

        public static int VratiSifruAktivnosti(Aktivnost a)
        {
            return k.VratiSifruAktivnosti(a);
        }

        public static bool SacuvajPaket(Paket p1, Istorija i1, List<PaketAkt> listaPA1)
        {
            List<int> listaUspeh = new List<int>();
            listaUspeh.Add(k.SacuvajPaket(p1));
            listaUspeh.Add(k.SacuvajIstoriju(i1));
            listaUspeh.Add(k.SacuvajPaketAkt(listaPA1));

            if (listaUspeh.Contains(0)) return false;
            else return true;
        }

        public static BindingList<Istorija> PronadjiBivsePakete(Istorija i)
        {
            BindingList<Istorija> listaIstorija = new BindingList<Istorija>();
            List<OpstiDomenskiObjekat> listaOdo = k.VratiListuIstorija(i);


            foreach (OpstiDomenskiObjekat odo in listaOdo)
            {
                Istorija ist = new Istorija();
                ist = (Istorija)odo;
                listaIstorija.Add(ist);
            }
            return listaIstorija;

        }

    }
}
