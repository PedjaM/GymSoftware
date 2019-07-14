using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using Server;

namespace Projektni
{
    public partial class FormaIzmenaProfila : Form
    {

        public FormaIzmenaProfila()
        {
            InitializeComponent();
            
        }

        public Korisnik k1;
        public FormaIzmenaProfila(Korisnik k)
        {
            InitializeComponent();
  
            k1 = k;

        }

        private void dugmeIzmenaProfilaOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaGlavna fg = new FormaGlavna(k1);
            fg.Show();
        }

        private void dugmeObrisiProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPotvrdaBrisanje fpb = new FormaPotvrdaBrisanje(k1);
            fpb.Show();
        }

        private void FormaIzmenaProfila_Load(object sender, EventArgs e)
        {

            if (!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greska: nije uspostavljena veza sa serverom");
            }
            tekstImeIzmenaProfila.Text = k1.Ime;
            tekstPrezimeIzmenaProfila.Text = k1.Prezime;
            tekstGodisteIzmenaProfila.Text = Convert.ToString(k1.Godiste);
            tekstPolIzmenaProfila.Text = k1.Pol;

            List<Grad> listaGradova =  KontrolerKI.VratiSveGradove();
            
            komboGradIzmenaProfila.DataSource = listaGradova;

            komboGradIzmenaProfila.DisplayMember = "Naziv";

            komboGradIzmenaProfila.Text = KontrolerKI.VratiNazivGrada(k1);  


        }

        private void dugmeSacuvaj_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.Ime = tekstImeIzmenaProfila.Text;
            if (k.Ime == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                tekstImeIzmenaProfila.Focus();
                return;
            }
            k.Prezime = tekstPrezimeIzmenaProfila.Text;
            if (k.Prezime == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                tekstPrezimeIzmenaProfila.Focus();
                return;
            }
            try
            {
                k.Godiste = Convert.ToInt32(tekstGodisteIzmenaProfila.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nepravilan format godišta! Neophodno je napisati godinu rođenja (npr. 1995)");
                return;
            }

            int trenutnaGodina = DateTime.Now.Year;
            if (!((trenutnaGodina - k.Godiste) > 15))
            {
                MessageBox.Show("Samo stariji od 15 godina mogu da budu članovi teretane!");
                tekstGodisteIzmenaProfila.Focus();
                return;
            }
            k.Pol = tekstPolIzmenaProfila.Text;
            if (!(k.Pol == "M" || k.Pol == "Z"))
            {
                MessageBox.Show("Polje 'Pol' mora da ima vrednost M ili Z");
                tekstPolIzmenaProfila.Focus();
                return;
            }
            k.Grad = komboGradIzmenaProfila.SelectedItem as Grad;
            k.IdKorisnika = k1.IdKorisnika;
            try
            {

                if(!KontrolerKI.ZapamtiUnetePodatke(k))
                {
                    MessageBox.Show("Podaci nisu sačuvani!");
                }
                else
                {
                    FormaGlavna fg = new FormaGlavna(k);
                    this.Hide();
                    fg.ShowDialog();
               
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void tekstImeIzmenaProfila_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
