using ConsoleApplication1.Decorator;
using ConsoleApplication1.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    public abstract class AbstractBuilder
    {
        protected Sector[][] sector { get; set; }
          

        public void crearSector(int n)
        {
            sector = new Sector[n][];
        } 

        public Sector[][] obtenerSector()
        {
            return sector;
        }

        public abstract void decorarSector();
    }
}
