using System;
using MetoIntegrador;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
   public class DenunciaPorMostrador : IDenuncias
    {
        private IDenuncia denuncia { get; set; }
        private ILugar lugar { get; set; }
        
        public DenunciaPorMostrador(ILugar lugar)
        {
            this.lugar = lugar;
            this.denuncia = new DenunciaDeIncendio(lugar);
        }

        public Iterator crearIterador()
        {
            return new IterDenunciaPorMostrador(denuncia);
        }
    }
}
