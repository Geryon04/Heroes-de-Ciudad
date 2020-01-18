using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class FabricaMedico : IFabricaDeHeroes
    {
        private IResponsable siguiente { get; set; }
        public FabricaMedico(IResponsable responsable)
        {
            siguiente = responsable;
        }

        public ICuartel crearCuartel()
        {
            return Hospital.getInstancia();
        }

        public IResponsable crearHeroe()
        {
            return new Medico(siguiente);
        }

        public IHerramienta crearHerramienta()
        {
            return new Desfribilador();
        }

        public IVehiculo crearVehiculo()
        {
            return new Ambulancia();
        }
    }
}
