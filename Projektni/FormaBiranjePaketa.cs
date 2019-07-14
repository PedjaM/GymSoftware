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
    public partial class FormaBiranjePaketa : Form
    {
        public Korisnik k1;
        Double ukupnaCena;
        string nazivAktivnosti;
        List<PaketAkt> listaPA = new List<PaketAkt>();


        private void FormaBiranjePaketa_Load(object sender, EventArgs e)
        {
          
        }

        public FormaBiranjePaketa()
        {
            
            InitializeComponent();
         

        }

        public FormaBiranjePaketa(Korisnik k)
        {
            k1 = k;
            InitializeComponent();
            if (!KontrolerKI.PoveziSeNaServer())
            {
                MessageBox.Show("Greska, nije uspostavljena veza sa serverom!");
            }
         
            DataTable dt = new DataTable();
            dt.Columns.Add("Izaberi", Type.GetType("System.Boolean"));

            dt.Columns.Add("Aktivnost");
            dt.Columns.Add("Cena");

      
            DataRow dr;
           
            List<Aktivnost> la = KontrolerKI.UcitajListuAktivnosti();
                
            for (int i = 0; i <= la.Count-1; i++)

            {

                dr = dt.NewRow();

                dr["Izaberi"] = false;
               
                dr["Aktivnost"] = la[i].Naziv;

                dr["Cena"] = la[i].Cena;

                dt.Rows.Add(dr);

            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }

        private void cekListaBiranjePaketa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dugmeOdustaniBiranjePaketa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaGlavna fg = new FormaGlavna(k1);
            fg.Show();
        }

        

        private void dugmeIzaberiBiranjePaketa_Click(object sender, EventArgs e)
        {
            TimeSpan temp = dateDoBiranje.Value - dateOdBiranje.Value;
       
            int razlika = temp.Days;
            
            if(razlika+1 < 1)
            {
                MessageBox.Show("Nije moguće izabrati paket koji toliko kratko traje");
                return;
            }
            else
            {

                Paket p = KontrolerKI.VratiPaket();

                foreach (DataGridViewRow red in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk = red.Cells[0] as DataGridViewCheckBoxCell;
                    string nazivAkt = Convert.ToString(red.Cells[1].Value);
                    double cenaAkt = Convert.ToDouble(red.Cells[2].Value);

                 

                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        ukupnaCena += cenaAkt/30;
                        nazivAktivnosti = nazivAkt;

                        PaketAkt pa = new PaketAkt();
                        pa.IdPaketa = p.IdPaketa;
                        Aktivnost a = new Aktivnost();
                        a.Naziv = nazivAktivnosti;
                        pa.IdAktivnosti = KontrolerKI.VratiSifruAktivnosti(a);


                        listaPA.Add(pa);
                    }
                }
                ukupnaCena = ukupnaCena* (razlika+1);
                ukupnaCena = Math.Round(ukupnaCena);

                if(listaPA.Count < 1)
                {
                    MessageBox.Show("Neophodno je izabrati bar jednu aktivnost!");
                    return;
                }

                p.UkupnaCena = ukupnaCena;

                Istorija i = new Istorija();
                i.IdKorisnika = k1.IdKorisnika;
                i.IdPaketa = p.IdPaketa;
                DateTime danas = DateTime.Today;
  
                i.DatumUplate = danas.Date;
                i.DatumPocetka = dateOdBiranje.Value.Date;
                i.DatumZavrsetka = dateDoBiranje.Value.Date;
          

                this.Hide();
                new FormaPotvrdaUplata(k1, p, listaPA, i, razlika).ShowDialog();
            }
          
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
                
        }



            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
}
