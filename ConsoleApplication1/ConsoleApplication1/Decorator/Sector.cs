using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator
{
    public class Sector : ISector
    {
        public double afectacionDelFuego { get; set ; }

        public Sector(double afectacionDelFuego)
        {
            this.afectacionDelFuego = afectacionDelFuego;
        }

        public Sector()
        {
        }

        public void mojar(double agua)
        {

            afectacionDelFuego = afectacionDelFuego - agua;
        }

        public bool estaApagado()
        {
            return afectacionDelFuego < 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }


}
