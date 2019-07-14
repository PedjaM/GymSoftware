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


    public partial class FormaPrijava : Form
    {
        KontrolerKI ki;
        public FormaPrijava()
        {
            InitializeComponent();
        }

 

        private void FormaPrijava_Load(object sender, EventArgs e)
        {
            ki = new KontrolerKI();
            if(!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greska: nije uspostavljena veza sa serverom");
                dugmePrijavi.Enabled = false;
                dugmeRegistracija.Enabled = false;
                tekstBrojKarticePrijava.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DugmePrijavi_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            if (tekstBrojKarticePrijava.Text == "")
            {
                MessageBox.Show("Morate uneti neki broj!");
            }
        
            try
            {
                k.IdKorisnika = Convert.ToInt32(tekstBrojKarticePrijava.Text);
               if(k.IdKorisnika.GetType().ToString() != "System.Int32")
                {
                    MessageBox.Show("Nije dozvoljen unos ničega osim celobrojne vrednosti!");
                }

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

            try
            {
                k = KontrolerKI.PrijaviKorisnika(k);
                if (k != null)
                {
                    this.Hide();
                    new FormaGlavna(k).ShowDialog();
                }
                else
                {
                    MessageBox.Show("U sistemu ne postoji korisnik sa tim brojem kartice!");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
         
        }

        private void DugmePrijavaKraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.Kraj();
            Application.Exit();
        }

        private void DugmeRegistracija_Click(object sender, EventArgs e)
        {
            FormaRegistracija fr = new FormaRegistracija();
            this.Hide();
            fr.Show();
        }
    }



}
