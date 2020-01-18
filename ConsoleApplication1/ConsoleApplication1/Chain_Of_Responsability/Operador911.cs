using System;
using ConsoleApplication1.Iterator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Chain_Of_Responsability
{
    public class Operador911 : IResponsable

    {
        private IResponsable responsable { get; set; }

        public Operador911(IResponsable responsable) : base(responsable)
        {
            this.responsable = responsable;
        }

        

        public void atenderDenuncias(IDenuncias denuncias)
        {
            Iterator.Iterator iter = denuncias.crearIterador();

            while (iter.hasNext())
            {
                IDenuncia actual= (IDenuncia)iter.Next();
                actual.atender(responsable);

            }
        }
        
     
       


    }
}
