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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projektni
{
    public partial class FormaIstorija : Form
    {

        public Korisnik k1;
        public int idPaketa;
        BindingList<Istorija> listaIstorija;
        Komunikacija kom;

        public FormaIstorija()
        {
            InitializeComponent();
        }
       
        public FormaIstorija(Korisnik k)
        {
            k1 = k;
            InitializeComponent();

            if (!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greška, nije uspostavljena veza sa serverom");
            }
            Istorija i = new Istorija();
            i.IdKorisnika = k1.IdKorisnika;

            listaIstorija = KontrolerKI.PronadjiBivsePakete(i);

            dataGridView1.DataSource = listaIstorija;

        }

        private void dugmeOdustaniIstorija_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaGlavna(k1).ShowDialog();
        }

        private void dugmeOtkaziIstorija_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaPotvrdaOtkazivanje(k1, idPaketa).ShowDialog();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Istorija i = dataGridView1.CurrentRow.DataBoundItem as Istorija;
        
           

            PaketAkt pa = new PaketAkt();
            pa.IdPaketa = i.IdPaketa;

            kom = new Komunikacija();
            listaAktivnostiIstorija.DataSource = kom.VratiAktivnostiPaketa(pa);
                                    //Broker.DajSesiju().vratiAktivnostiPaketa(idPaketa);
                                    //listaAktivnostiIstorija.DisplayMember = "Naziv";
                                    //txtDatumOd.Text = kom.VratiCenuIDatume(p)[0];
                                    ////Broker.DajSesiju().vratiCenuIDatume(idPaketa)[0];
                                    //txtDatumDo.Text =kom.VratiCenuIDatume(p)[1];
                                    ////Broker.DajSesiju().vratiCenuIDatume(idPaketa)[1];
                                    //txtCenaVrednost.Text = kom.VratiCenuIDatume(p)[2];
                                    ////Broker.DajSesiju().vratiCenuIDatume(idPaketa)[2];
        }

        private void FormaIstorija_Load(object sender, EventArgs e)
        {
  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
