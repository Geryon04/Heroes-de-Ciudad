using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class DiaLluvioso : Decorator
    {
        private double intensidadDeLluvia { get; set; }
        public DiaLluvioso(Sector s) : base(s)
        {
            intensidadDeLluvia = new Random().Next();
        }

        public override bool estaApagado()
        {
            return SectorInterno.estaApagado();
        }

        public override void mojar(double agua)
        {
            double aguaActual = agua + intensidadDeLluvia;
            SectorInterno.mojar(aguaActual);
        }
    }
}
