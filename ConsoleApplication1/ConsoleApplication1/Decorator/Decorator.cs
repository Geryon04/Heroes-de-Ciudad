using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public abstract class Decorator : Sector
    {
        public ISector SectorInterno { get; set; }

        protected Decorator(Sector s)
        {
            SectorInterno = s;
        }

        public abstract void mojar(double agua);
        public abstract bool estaApagado();
    }
}
