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
    public partial class FormaRegistracija : Form
    {
        KontrolerKI ki;
        public FormaRegistracija()
        {
            InitializeComponent();

        }

        private void FormaRegistracija_Load(object sender, EventArgs e)
        {
            
            if (!KontrolerKI.PoveziSeNaServer())
            {
           
                this.Hide();
                new FormaPrijava().ShowDialog();
            }

            List<Grad> listaGradova = KontrolerKI.VratiSveGradove();

            komboGradRegistracija.DataSource = listaGradova;
            komboGradRegistracija.DisplayMember = "Naziv";
        }

        private void DugmeRegistracijaKraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijava fp = new FormaPrijava();
            fp.Show();
        }

        private void DugmeRegistruj_Click(object sender, EventArgs e)
        {
           
            Korisnik k = new Korisnik();
            k.Ime = tekstImeRegistracija.Text;
            if(k.Ime == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                tekstImeRegistracija.Focus();
                return;
            }
            k.Prezime = tekstPrezimeRegistracija.Text;
            if (k.Prezime == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                tekstPrezimeRegistracija.Focus();
                return;
            }
            try
            {
                k.Godiste = Convert.ToInt32(tekstGodisteRegistracija.Text);
            }catch(Exception)
            {
                MessageBox.Show("Nepravilan format godišta!");
                return;
            }

            int trenutnaGodina = DateTime.Now.Year;
            if (!((trenutnaGodina - k.Godiste) > 15))
            {
                MessageBox.Show("Samo stariji od 15 godina mogu da budu članovi teretane!");
                tekstGodisteRegistracija.Focus();
                return;
            }
            k.Pol = tekstPolRegistracija.Text;
            if (!(k.Pol == "M" || k.Pol == "Z"))
            {
                MessageBox.Show("Polje 'Pol' mora da ima vrednost M ili Z");
                tekstPolRegistracija.Focus();
                return;
            }
            k.Grad = komboGradRegistracija.SelectedItem as Grad;


            k = KontrolerKI.RegistrujKorisnika(k);
            
                if(k == null)
                {
                    MessageBox.Show("Došlo je do greške, korisnik nije sačuvan");
                    return;
                }
                else
                {
                    FormaGlavna fg = new FormaGlavna(k);
                    this.Hide();
                    fg.Show();
                }

             
            
        
         
        }
    }
}
