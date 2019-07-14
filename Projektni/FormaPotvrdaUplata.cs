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
    public partial class FormaPotvrdaUplata : Form
    {
        public Korisnik k1;
        public Paket p1;
        public List<PaketAkt> listaPA1;
        public Istorija i1;


        public FormaPotvrdaUplata()
        {
            InitializeComponent();
        }

        public FormaPotvrdaUplata(Korisnik k, Paket p, List<PaketAkt> listaPA, Istorija i, int razlika)
        {
            InitializeComponent();
            k1 = k;
            p1 = p;
            listaPA1 = listaPA;
        
            i1 = i;
            if(!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greska: nije uspostavljena veza sa serverom");
            }
            txtUkupnaCenaUplata.Text = p1.UkupnaCena.ToString("0.##") + " din";
            
            if (razlika + 1 == 1 || razlika + 1 == 31)
            {
                txtVremeTrajanjaUplata.Text = Convert.ToString(razlika + 1) + " dan";
            }
            else
            {
                txtVremeTrajanjaUplata.Text = Convert.ToString(razlika + 1) + " dana";
            }
        }

      

        private void dugmeNeOdustaniUplata_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaBiranjePaketa(k1).ShowDialog();
          
        }

        private void dugmeDaUplatiUplata_Click(object sender, EventArgs e)
        {
            try
            {

                if (!KontrolerKI.SacuvajPaket(p1, i1, listaPA1)) MessageBox.Show("Nije sačuvano");
                else
                {
                    this.Hide();
                    new FormaBiranjePaketa(k1).ShowDialog();
                }



            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return;
            }
        }

        private void FormaPotvrdaUplata_Load(object sender, EventArgs e)
        {

        }
    }
}
