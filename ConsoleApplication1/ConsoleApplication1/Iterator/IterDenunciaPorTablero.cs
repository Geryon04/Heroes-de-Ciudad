using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class IterDenunciaPorTablero : Iterator
    {
        private int posActual { get; set; }
        private List<IDenuncia> denuncias { get; set; }

        public IterDenunciaPorTablero(IDenuncias denuncia)
        {
            posActual = 0;
            this.denuncias = ((DenunciaPorTablero)denuncia).denuncias; 
        }
        public bool hasNext()
        {
            return (posActual < denuncias.Count) ? true : false;
        }

        public object Next()
        {
            int aux = posActual;
            posActual++;
            return denuncias[aux];
        }
    }
}
