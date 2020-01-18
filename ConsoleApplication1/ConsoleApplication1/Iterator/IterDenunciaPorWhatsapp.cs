using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class IterDenunciaPorWhatsapp : Iterator
    {
        public MensajeWhatsapp mensaje { get; set; }

        public IterDenunciaPorWhatsapp(IDenuncias denuncia)
        {
            mensaje = ((DenunciaPorWhatsapp)denuncia).mensaje;
        }
        public bool hasNext()
        {
            return mensaje != null;
        }

        public object Next()
        {
            MensajeWhatsapp aux = mensaje;
            mensaje = mensaje.siguiente;
            return aux.denuncia;
  
        }
    }
}
