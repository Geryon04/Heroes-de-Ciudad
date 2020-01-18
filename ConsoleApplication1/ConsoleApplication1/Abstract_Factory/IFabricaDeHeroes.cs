using System;
using ConsoleApplication1.Iterator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Abstract_Factory
{
   public interface IFabricaDeHeroes
    {
        IResponsable crearHeroe();
        IVehiculo crearVehiculo();
        IHerramienta crearHerramienta();
        ICuartel crearCuartel();
    }
}
