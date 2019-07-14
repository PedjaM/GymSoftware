using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Projektni
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }

        public bool Kraj()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.Kraj;
                formater.Serialize(tok, transfer);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public Korisnik Login(Korisnik k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.Login;
                transfer.zahtev = k;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                Korisnik k1 = transfer.rezultat as Korisnik;
                return k1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OpstiDomenskiObjekat> VratiSveGradove()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSveGradove;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                List<OpstiDomenskiObjekat> lg  = transfer.rezultat as List<OpstiDomenskiObjekat>;
                return lg;
              
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Korisnik RegistrujKorisnika(Korisnik k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.RegistrujKorisnika;
                transfer.zahtev = k;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                 k = transfer.rezultat as Korisnik;
                return k;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Grad VratiNazivGrad(Grad g)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiNazivGrad;
                transfer.zahtev = g;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                g = transfer.rezultat as Grad;
                return g;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int IzmeniProfilKorisnika(Korisnik k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.IzmeniProfilKorisnika;
                transfer.zahtev = k;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int x = (int)transfer.rezultat;
                return x;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int ObrisiKorisnika(Korisnik k)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.ObrisiKorisnika;
                transfer.zahtev = k;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int x = (int)transfer.rezultat;
                return x;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public List<OpstiDomenskiObjekat> VratiListuAktivnosti()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiListuAktivnosti;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                List<OpstiDomenskiObjekat> rezultat = transfer.rezultat as List<OpstiDomenskiObjekat>;
                return rezultat;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int VratiSifruPaketa()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSifruPaketa;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int s = (int)transfer.rezultat;
                return s;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int SacuvajPaket(Paket p)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.SacuvajPaket;
                transfer.zahtev = p;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int x = (int)transfer.rezultat;
                return x;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public int SacuvajIstoriju(Istorija i)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.SacuvajIstoriju;
                transfer.zahtev = i;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int x = (int)transfer.rezultat;
                return x;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public int SacuvajPaketAkt(List<PaketAkt> listaPAkt)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.SacuvajPaketAkt;
                transfer.zahtev = listaPAkt;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int x = (int)transfer.rezultat;
                return x;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public int VratiSifruAktivnosti(Aktivnost a)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSifruAktivnosti;
                transfer.zahtev = a;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                int s = (int)transfer.rezultat;
                return s;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<OpstiDomenskiObjekat> VratiListuIstorija(Istorija i)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiListuIstorija;
                transfer.zahtev = i;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
       
                return transfer.rezultat as List<OpstiDomenskiObjekat>;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Aktivnost> VratiAktivnostiPaketa(PaketAkt pa)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiAktivnostiPaketa;
                transfer.zahtev = pa;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                List<Aktivnost> listaA = transfer.rezultat as List<Aktivnost>;
                return listaA;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> VratiCenuIDatume(Paket p)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiCenuIDatume;
                transfer.zahtev = p.ID;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                List<string> listaS = transfer.rezultat as List<string>;
                return listaS;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ObrisiLIP(int paketId)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.ObrisiLIP;
                transfer.zahtev = paketId;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
               int x= (int) transfer.rezultat;
                return x;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
