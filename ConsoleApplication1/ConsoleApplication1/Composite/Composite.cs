using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Composite
{
    public class Composite: IIluminable
    {
        IList<IIluminable> _Hijos = new List<IIluminable>();

        public void agregar(IIluminable i)
        {
            _Hijos.Add(i);
        }

        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("soy un composite");
            foreach (IIluminable i in _Hijos)
            {
                i.revisarYCambiarLamparasQuemadas();

            }
        }
    }
}
