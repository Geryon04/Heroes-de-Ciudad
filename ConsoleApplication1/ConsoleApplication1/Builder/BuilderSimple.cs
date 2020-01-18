using ConsoleApplication1.Decorator;
using ConsoleApplication1.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    public class BuilderSimple : AbstractBuilder
    {
        public override void decorarSector()
        {
            FactorySectores.crearSector(0);
        }
    }
}
