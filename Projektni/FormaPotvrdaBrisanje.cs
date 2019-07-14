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
    public partial class FormaPotvrdaBrisanje : Form
    {
        public Korisnik k1;
        public FormaPotvrdaBrisanje()
        {
            InitializeComponent();
            labelTekstBrisanje.Text = "Da li ste sigurni da  " + "\n" + "želite da obrišete profil?";
        }

        public FormaPotvrdaBrisanje(Korisnik k)
        {
            InitializeComponent();
            k1 = k;
            labelTekstBrisanje.Text = "Da li ste sigurni da  " + "\n" + "želite da obrišete profil?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dugmeNeOdustaniProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaIzmenaProfila fip = new FormaIzmenaProfila(k1);
            fip.Show();
        }

        private void FormaPotvrdaBrisanje_Load(object sender, EventArgs e)
        {
            if(!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greška, nije uspostavljena veza sa serverom");
            }
        }

        private void dugmeDaObrisiProfil_Click(object sender, EventArgs e)
        {
            try
            {
                if(!KontrolerKI.ObrisiProfil(k1))
                {
                    MessageBox.Show("Došlo je do greške, korisnik nije obrisan");
                }
                else
                {
                    FormaPrijava fp = new FormaPrijava();
                    this.Hide();
                    fp.ShowDialog();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
    }
}
