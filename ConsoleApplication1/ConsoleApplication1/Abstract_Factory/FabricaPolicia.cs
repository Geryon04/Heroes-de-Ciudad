using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Command;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class FabricaPolicia : IFabricaDeHeroes
    {
        private IOrden orden { get; set; }
        private IPatrullable patrullable { get; set; }
        private IResponsable siguiente { get; set; }
        public FabricaPolicia(IOrden orden, IPatrullable patrullable, IResponsable responsable)
        {
            this.orden = orden;
            this.patrullable = patrullable;
            siguiente = responsable;
        }

        public ICuartel crearCuartel()
        {
            return Comisaria.getInstancia();
        }

        public IResponsable crearHeroe()
        {
            return new Policia(orden, patrullable, siguiente);
        }

        public IHerramienta crearHerramienta()
        {
            return new Pistola();
        }

        public IVehiculo crearVehiculo()
        {
            return new Patrullero();
        }
    }
}
