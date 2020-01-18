using ConsoleApplication1.Template_Method;
using HeroesDeCiudad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Adapter
{
    public class Adapter : IInfartable
    {
        Passerby extranjero;
        public Adapter(Passerby extranjero)
        {
            this.extranjero = extranjero;
        }

        public bool estasConciente()
        {
            return extranjero.isConscious();
        }

        public bool estasRespirando()
        {
            return extranjero.isBreathing();
        }

        public bool tenesRitmoCardiaco()
        {
            return extranjero.haveHeartRate();
        }
    }
}
