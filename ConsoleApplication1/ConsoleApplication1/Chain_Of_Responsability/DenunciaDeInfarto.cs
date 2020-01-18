using System;
using MetoIntegrador.Hero;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Template_Method;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Chain_Of_Responsability
{
    public class DenunciaDeInfarto : IDenuncia
    {
        private IInfartable transeunte { get; set; }

        public DenunciaDeInfarto(IInfartable transeunte)
        {
            this.transeunte = transeunte;
        }
        public void atender(IResponsable unResponsable)
        {
            (unResponsable).AtenderInfarto(transeunte);
        }
    }
}
