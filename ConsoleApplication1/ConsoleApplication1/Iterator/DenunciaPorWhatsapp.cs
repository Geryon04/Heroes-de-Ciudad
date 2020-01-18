using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class DenunciaPorWhatsapp : IDenuncias
    {
        public MensajeWhatsapp mensaje { get; set; }

        public DenunciaPorWhatsapp( MensajeWhatsapp mensaje)
        {
            this.mensaje = mensaje;
        }
        public Iterator crearIterador()
        {
            return new IterDenunciaPorWhatsapp(this);
        }
    }
}
