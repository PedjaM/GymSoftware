﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.Istorija
{
    class ObrisiIstoriju:OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {


            return Broker.DajSesiju().delete(odo as OpstiDomenskiObjekat);


        }
    }
}
