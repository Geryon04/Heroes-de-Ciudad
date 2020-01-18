using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class DiaDeCalor : Decorator
    {
        private double Temperatura { get; set; }
        public DiaDeCalor(Sector s) : base(s)
        {
             Temperatura = new Random().Next();
        }
        public override bool estaApagado()
        {
            return SectorInterno.estaApagado();
        }

        public override void mojar(double agua)
        {
            Double aguaActual = agua - (0.1 * Temperatura);
            SectorInterno.mojar(aguaActual);
        }
    }
}
