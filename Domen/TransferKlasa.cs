using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije
    {
        Kraj = 1,
        Login = 2,
        VratiSveGradove = 3,
        RegistrujKorisnika = 4,
        VratiNazivGrad = 5,
        IzmeniProfilKorisnika = 6,
        ObrisiKorisnika = 7,
        VratiListuAktivnosti = 8,
        VratiSifruPaketa = 9,
        SacuvajPIL = 10,
        VratiSifruAktivnosti = 11,
        VratiListuIstorija = 12,
        VratiAktivnostiPaketa = 13,
        VratiCenuIDatume = 14,
        ObrisiLIP = 15,
        SacuvajPaket = 16,
        SacuvajIstoriju = 17,
        SacuvajPaketAkt = 18
    }

    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object zahtev;
        public Object rezultat;
    }
}
