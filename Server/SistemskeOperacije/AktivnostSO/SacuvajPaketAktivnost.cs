﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SistemskeOperacije.AktivnostSO
{
    public class SacuvajPaketAktivnost : OpstaSistemskaOperacija
    {
        public override object Izvrsi(object odo)
        {
            return Broker.DajSesiju().insert(odo as OpstiDomenskiObjekat);
        }
    }
}
