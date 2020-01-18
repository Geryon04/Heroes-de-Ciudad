using System;
using MetoIntegrador.Hero;
using ConsoleApplication1.Command;
using ConsoleApplication1.Iterator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Chain_Of_Responsability
{
    public class DenunciaDeRobo : IDenuncia
    {
        private IPatrullable patrullable { get; set; }

        public DenunciaDeRobo(IPatrullable patrullable)
        {
            this.patrullable = patrullable;
        }
        public void atender(IResponsable unResponsable)
        {
            (unResponsable).PatrullarCalles();
        }
    }
}
