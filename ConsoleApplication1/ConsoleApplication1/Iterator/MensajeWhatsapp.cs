using System;
using MetoIntegrador;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class MensajeWhatsapp 
    {
        public IDenuncia denuncia { get; set; }
        public MensajeWhatsapp siguiente { get; set; }
        //private ILugar lugar;

        public MensajeWhatsapp(IDenuncia denuncia, MensajeWhatsapp mensaje)
        {
            this.denuncia = denuncia;
            siguiente = mensaje;
        }
    }
}
