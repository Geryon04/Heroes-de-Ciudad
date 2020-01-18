using ConsoleApplication1.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
    public interface ICuartel
    {
        void agregarVehiculo(IVehiculo vehiculo);
        void agregarPersonal(IResponsable responsable);
        void agregarHerramienta(IHerramienta herramienta);
        IResponsable getPersonal();
    }
}
