using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class IterDenunciaPorMostrador : Iterator
    {
        private IDenuncia denuncia { get; set; }

        public IterDenunciaPorMostrador(IDenuncia denuncia)
        {
            this.denuncia = denuncia; 
        }
        public bool hasNext()
        {
            return (denuncia != null); 
        }

        public object Next()
        {
            IDenuncia aux = denuncia;
            denuncia = null;
            return aux;

        }
    }
}
