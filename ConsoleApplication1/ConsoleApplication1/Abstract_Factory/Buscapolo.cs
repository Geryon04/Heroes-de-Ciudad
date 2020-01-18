using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Buscapolo : IHerramienta
    {
        public void Guardar()
        {
            Console.WriteLine("Guardar en caja de herramientas");
        }

        public void usar()
        {
            Console.WriteLine("Buscar polos");
        }
    }
}
