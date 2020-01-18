using System;
using MetoIntegrador.Hero;
using ConsoleApplication1.Composite;
using ConsoleApplication1.Iterator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Chain_Of_Responsability
{
    public class DenunciaDeLamparaQuemada : IDenuncia
    {
        private IIluminable iluminable { get; set; }
        public DenunciaDeLamparaQuemada(IIluminable iluminable)
        {
            this.iluminable = iluminable;
        }

        public void atender(IResponsable unResponsable)
        {
            (unResponsable).Revisar(iluminable);
        }
    }
}
