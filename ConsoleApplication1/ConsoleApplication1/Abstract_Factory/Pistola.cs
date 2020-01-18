using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Pistola : IHerramienta
    {
        public void Guardar()
        {
            Console.WriteLine("Enfundar arma");
        }

        public void usar()
        {
            Console.WriteLine("Desenfundar arma");
        }
    }
}
