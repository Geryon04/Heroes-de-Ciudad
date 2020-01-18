using System;
using MetoIntegrador;
using ConsoleApplication1.Observer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class DenunciaPorTablero : IDenuncias, Observer.Observer
    {
        public List<IDenuncia> denuncias { get; set; }

        public DenunciaPorTablero()
        {
            denuncias = new List<IDenuncia>();
        }

        public void actualizar(Observable o)
        {
            denuncias.Add(new DenunciaDeIncendio((ILugar)o));
        }


        public Iterator crearIterador()
        {
            return new IterDenunciaPorTablero(this);
        }
    }
}
