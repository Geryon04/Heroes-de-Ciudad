﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class PastoSeco : Decorator
    {
        public PastoSeco(Sector s) : base(s)
        {
        }

        public override bool estaApagado()
        {
            return SectorInterno.estaApagado();
        }

        public override void mojar(double agua)
        {
            double aguaActual = agua / 2;
            SectorInterno.mojar(aguaActual);
        }
    }
}
