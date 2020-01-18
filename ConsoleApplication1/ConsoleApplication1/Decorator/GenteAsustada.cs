using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class GenteAsustada : Decorator
    {
        public double cantidadDePersonas { get; set; }
        public GenteAsustada(Sector s) : base(s)
        {
            cantidadDePersonas = new Random().Next(5);
        }

        public override bool estaApagado()
        {
            return SectorInterno.estaApagado();
        }

        public override void mojar(double agua)
        {
            double aguaActual = agua;
            for(double veces = 0; veces < cantidadDePersonas; veces++)
            {
                aguaActual = aguaActual - ((aguaActual / 4) * 3);
            }
            SectorInterno.mojar(aguaActual);
        }
    }
}
