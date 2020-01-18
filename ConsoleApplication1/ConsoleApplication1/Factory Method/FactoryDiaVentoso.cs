using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Decorator;

namespace ConsoleApplication1.Factory_Method
{
    public class FactoryDiaVentoso : FactorySectores
    {
        public override ISector crearSector(Sector s)
        {
            Decorator.Decorator sector = new DiaVentoso(s);
            return sector;
        }
    }
}
