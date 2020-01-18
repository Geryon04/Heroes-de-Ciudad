using System;
using ConsoleApplication1.Composite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetoIntegrador.Places;
using MetoIntegrador;
using ConsoleApplication1.Template_Method;

namespace ConsoleApplication1.Iterator
{
    public abstract class IResponsable
    {
        IResponsable siguiente = null;

        public IResponsable(IResponsable responsable)
        {
            siguiente = responsable;
        } 

        public virtual void Revisar(IIluminable i)
        {
            if(siguiente != null)
            {
                siguiente.Revisar(i);
            }
            else
            {
                Console.WriteLine("El problema no se pudo solucionar");
            }
        }

        public virtual void ApagarIncendio(ILugar lugar, Calle calle)
        {
            if(siguiente != null)
            {
                siguiente.ApagarIncendio(lugar, calle);
            }
            else
            {
                Console.WriteLine("El problema no se pudo solucionar");
            }
        }

        public virtual void AtenderInfarto(IInfartable transeunte)
        {
            if(siguiente != null)
            {
                siguiente.AtenderInfarto(transeunte);
            }
            else
            {
                Console.WriteLine("El problema no se pudo solucionar");
            }
        }

        public virtual void PatrullarCalles()
        {
            if(siguiente != null)
            {
                siguiente.PatrullarCalles();
            }
            else
            {
                Console.WriteLine("El problema no se pudo solucionar");
            }
        }

    }
}
