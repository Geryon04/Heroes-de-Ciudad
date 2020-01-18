using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class DiaVentoso : Decorator
    {
        private double velocidadDelViento { get; set; }
        public DiaVentoso(Sector s) : base(s)
        {
            velocidadDelViento = new Random().Next();
        }

        public override bool estaApagado()
        {
            return SectorInterno.estaApagado();
        }

        public override void mojar(double agua)
        {
            double aguaActual = agua - (Math.Exp(velocidadDelViento / 100));
            SectorInterno.mojar(aguaActual);
            
        }
    }
}
