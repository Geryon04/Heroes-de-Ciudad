using ConsoleApplication1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory_Method
{
    public class FactoryDiaLluvioso : FactorySectores
    {
        //public FactoryDiaLluvioso()
        //{
        //}

        public override ISector crearSector(Sector s)
        {
            Decorator.Decorator sector = new DiaLluvioso(s);
            return sector;
        }
    }
}
