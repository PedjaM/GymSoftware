using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public Object IzvrsiSO(object odo)
        {
            Object rez = null;
            try
            {
                Broker.DajSesiju().OtvoriKonekciju();
                Broker.DajSesiju().zapocniTransakciju();
                rez = Izvrsi(odo);
                Broker.DajSesiju().potvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.DajSesiju().ponistiTransakciju();

            }
            finally { Broker.DajSesiju().ZatvoriKonekciju(); }
            return rez;
        }
        public abstract Object Izvrsi(object odo);
    }
}
