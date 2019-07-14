using Domen;
using Server.SistemskeOperacije.AktivnostSO;
using Server.SistemskeOperacije.GradSO;
using Server.SistemskeOperacije.Istorija;
using Server.SistemskeOperacije.KorisnikSO;
using Server.SistemskeOperacije.PaketSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Server
{
    public class NitKlijenta
    {
        NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();
            ThreadStart ts = Obradi;
            new Thread(ts).Start();
            
        }

        public void Obradi()
        {
            try
            {
                int operacija = 0;
                while(operacija != (int) Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch(transfer.Operacija)
                    {
                        case Operacije.Kraj:
                            operacija = 1;
                            break;
                        case Operacije.Login:
                            PrijaviKorisnika l = new PrijaviKorisnika();
                            transfer.rezultat = l.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveGradove:
                            VratiSveGradove vsg = new VratiSveGradove();
                            Grad g = new Grad();
                            transfer.rezultat = vsg.IzvrsiSO(g);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.RegistrujKorisnika:
                            RegistrujKorisnika rk = new RegistrujKorisnika();
                            transfer.rezultat = rk.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiNazivGrad:
                            VratiNazivGrada vng = new VratiNazivGrada();
                            transfer.rezultat = vng.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniProfilKorisnika:
                            Korisnik kori = transfer.zahtev as Korisnik;
                            IzmeniProfil ip = new IzmeniProfil();
                            transfer.rezultat = ip.IzvrsiSO(kori);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiKorisnika:
                            Korisnik koris = transfer.zahtev as Korisnik;
                            ObrisiKorisnika ok = new ObrisiKorisnika();
                            transfer.rezultat = ok.IzvrsiSO(koris);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiListuAktivnosti:
                            VratiListuAktivnosti vla = new VratiListuAktivnosti();
                            Aktivnost a = new Aktivnost();
                            transfer.rezultat = vla.IzvrsiSO(a as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSifruPaketa:
                            VratiSifruPaketa vsp = new VratiSifruPaketa();
                            Paket pkt = new Paket();
                            transfer.rezultat = vsp.IzvrsiSO(pkt);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajPaket:
                            SacuvajPaket sp = new SacuvajPaket();
                            transfer.rezultat = sp.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajIstoriju:
                            SacuvajIstoriju si = new SacuvajIstoriju();
                            transfer.rezultat = si.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.SacuvajPaketAkt:
                            SacuvajPaketAktivnost spa = new SacuvajPaketAktivnost();
                            List<PaketAkt> listPA = transfer.zahtev as List<PaketAkt>;
                            List<int> rez = new List<int>();
                            foreach(PaketAkt pa in listPA)
                            {
                                rez.Add((int)spa.IzvrsiSO(pa as OpstiDomenskiObjekat));
                            }
                            if (rez.Contains(0)) transfer.rezultat = 0;
                            else transfer.rezultat = 1;
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSifruAktivnosti:
                            
                            VratiSifruAktivnosti vsa = new VratiSifruAktivnosti();
                            transfer.rezultat = vsa.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiListuIstorija:
                            Istorija i = transfer.zahtev as Istorija;
                            VratiListuIstorija vli = new VratiListuIstorija();
                            transfer.rezultat = vli.IzvrsiSO(i as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiAktivnostiPaketa:
                           
                            VratiAktivnostiPaketa vap = new VratiAktivnostiPaketa();
                            transfer.rezultat = vap.IzvrsiSO(transfer.zahtev as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiCenuIDatume:
                            int y = (int)transfer.zahtev;
                            VratiCenuIDatume vcid = new VratiCenuIDatume();
                            transfer.rezultat = vcid.IzvrsiSO(vcid as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiLIP:
                            int z = (int)transfer.zahtev;
                            ObrisiLIP lip = new ObrisiLIP();
                            transfer.rezultat = lip.IzvrsiSO(lip as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
