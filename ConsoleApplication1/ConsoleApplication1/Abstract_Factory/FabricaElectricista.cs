using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class FabricaElectricista : IFabricaDeHeroes
    {
        private IResponsable siguiente { get; set; }
        public FabricaElectricista(IResponsable responsable)
        {
            siguiente = responsable;
        }

        public ICuartel crearCuartel()
        {
            return CentralElectrica.getInstancia();
        }

        public IResponsable crearHeroe()
        {
            return new Electricista(siguiente);
        }

        public IHerramienta crearHerramienta()
        {
            return new Buscapolo();
        }

        public IVehiculo crearVehiculo()
        {
            return new Camioneta();
        }
    }
}
