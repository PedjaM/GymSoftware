using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;

namespace Server
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlCommand komanda;
        SqlTransaction transakcija;

        public static Broker instanca;
        public static Broker DajSesiju()
        {
            //otvara novu sesiju koja ima jednog brokera za rad sa bazom
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }

        public void OtvoriKonekciju()
        {
            try
            {

                konekcija = new SqlConnection(@"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=Teretana;Integrated Security=True");
                komanda = konekcija.CreateCommand();
                konekcija.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                SqlCommand komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {


                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {


                throw;
            }
        }

        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT MAX(" + odo.ID + ") FROM " + odo.NazivTabele;
                SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greška pri formiranju jedinstvene šifre!");
            }
        }

        public int vratiSifruZaNaziv(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select " + odo.ID + " FROM " + odo.NazivTabele+ " WHERE " + odo.UslovOpsti ;
                SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
                try
                {
                    return Convert.ToInt32(komanda.ExecuteScalar());
                 
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greška pri formiranju jedinstvene šifre!");
            }
        }

        public int insert(OpstiDomenskiObjekat odo)
        {

            string upit = "INSERT INTO " + odo.NazivTabele + " " + odo.Insert;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška pri unosu podataka u bazu!");
            }
        }

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {

                    lista.Add(odo.procitajRed(red));
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }

        }

        public OpstiDomenskiObjekat vratiJedanZaOpstiUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {

                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {

                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.procitajRed(red));
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslovIJoin(OpstiDomenskiObjekat odo)
        {//PaketAkt join Aktivnost on PaketAkt.IDAktivnost = Aktivnost.IDAktivnosti 
            //where IDPaket = " + paketId;
            string upit = "SELECT * FROM " + odo.NazivJoin + " WHERE " + odo.UslovOpsti;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {

                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.procitajRed(red));
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }


        public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {

                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {

                throw new Exception("Greška u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int update(OpstiDomenskiObjekat odo)
        {

            string upit = "UPDATE " + odo.NazivTabele + " SET " + odo.Update + " WHERE " + odo.UslovID;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri ažuriranju podataka u bazi!");
            }
        }

        public int delete(OpstiDomenskiObjekat odo)
        {

            string upit = "DELETE FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("Greška pri brisanju iz baze!");
            }
        }

   
    }
}
