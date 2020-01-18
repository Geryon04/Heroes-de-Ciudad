using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Template_Method
{
    public class Transeunte : IInfartable
    {
        public bool estasConciente()
        {
            Double probabilidad = new Random().Next(101);
            return (probabilidad < 30) ? true : false ;
        }

        public bool estasRespirando()
        {
            Double probabilidad = new Random().Next(101);
            return (probabilidad < 30) ? true : false;
        }

        public bool tenesRitmoCardiaco()
        {
            Double probabilidad = new Random().Next(101);
            return (probabilidad < 30) ? true : false;
        }
    }
}
