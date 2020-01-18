using System;
using MetoIntegrador;
using MetoIntegrador.Hero;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public class DenunciaDeIncendio : IDenuncia
    {
        private ILugar lugar { get; set; }

        public DenunciaDeIncendio(ILugar lugar)
        {
            this.lugar = lugar;
        }
        public void atender(IResponsable unResponsable)
        {
            ((Bombero)unResponsable).ApagarIncendio(lugar, lugar.GetCalle());
        }
    }
}
