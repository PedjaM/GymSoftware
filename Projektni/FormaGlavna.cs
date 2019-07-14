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
    public partial class FormaGlavna : Form
    {
        Komunikacija kom;
        public Korisnik k1;

        public FormaGlavna()
        {
            InitializeComponent();
        }

        public FormaGlavna(Korisnik k)
        {
            k1 = k;
            InitializeComponent();
            brojKartice.Text = "Broj kartice: "+ Convert.ToString(k1.IdKorisnika);




        }

        private void FormaGlavna_Load(object sender, EventArgs e)
        {
   
        }

        private void DugmeGlavnaKraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Kraj();
            Application.Exit();
        }

        private void dugmeProfil_Click(object sender, EventArgs e)
        {
       
            FormaIzmenaProfila fip = new FormaIzmenaProfila(k1);
            
            this.Hide();
            fip.Show();
        }

        private void dugmeIstorija_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            FormaIstorija fi = new FormaIstorija(k1);
            fi.Show();
        }

        private void dugmeBiranjePaketa_Click(object sender, EventArgs e)
        {
            FormaBiranjePaketa fbp = new FormaBiranjePaketa(k1);
            this.Hide();
            fbp.Show();
        }
    }
}
