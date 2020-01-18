using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Desfribilador : IHerramienta
    {
        public void Guardar()
        {
            Console.WriteLine("Guardar Desfribilador");
        }

        public void usar()
        {
            Console.WriteLine("iniciando descarga");
        }
    }
}
