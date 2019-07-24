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
    public partial class FormaPotvrdaOtkazivanje : Form
    {

        public Korisnik k1;
        public int idPaketa1;
        public BindingList<Aktivnost> listaAktivnosti;

        public FormaPotvrdaOtkazivanje()
        {
          
            InitializeComponent();
            labelTekstOtkazivanje.Text = "Greška";
            

        }

        public FormaPotvrdaOtkazivanje(Korisnik k, int idPaketa, BindingList<Aktivnost> listaAktivnosti)
        {
            k1 = k;
            idPaketa1 = idPaketa;
            this.listaAktivnosti = listaAktivnosti;
            InitializeComponent();
      
            if (idPaketa == 0)
            {
                labelTekstOtkazivanje.Text = "Niste izabrali paket za otkazivanje";
                dugmeDaOtkaziPaket.Enabled = false;
            }
            else labelTekstOtkazivanje.Text = "Da li ste sigurni da " + "\n" + "želite da otkažete ovaj paket?";
            


        }

        private void dugmeDugmeNeOtkaziPaket_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaIstorija(k1).ShowDialog();
          
      
        }

        private void dugmeDaOtkaziPaket_Click(object sender, EventArgs e)
        {


            if (!KontrolerKI.OtkaziPaket(idPaketa1, listaAktivnosti)) MessageBox.Show("Nije sačuvano!");
            else
            {
                this.Hide();
                new FormaIstorija(k1).ShowDialog();
            }




        }

        private void FormaPotvrdaOtkazivanje_Load(object sender, EventArgs e)
        {

        }
    }
    }

