using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Manguera : IHerramienta
    {
        public void Guardar()
        {
            Console.WriteLine("Enrollar manguera");
        }

        public void usar()
        {
            Console.WriteLine("Tirar agua");
        }
    }
}
