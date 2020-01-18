using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;
using MetoIntegrador;
using ConsoleApplication1.Decorator;

namespace ConsoleApplication1.Abstract_Factory
{
    public class FabricaBombero : IFabricaDeHeroes
    {
        private IStrategy estrategia { get; set; }
        private Decorator.Decorator decorador { get; set; }
        private IResponsable siguiente { get; set; }
        public FabricaBombero(IStrategy estrategia, Decorator.Decorator decorador, IResponsable responsable)
        {
            this.estrategia = estrategia;
            this.decorador = decorador;
            siguiente = responsable;
        }

        public ICuartel crearCuartel()
        {
            return CuartelDeBomberos.getInstancia();
        }

        public IResponsable crearHeroe()
        {
            return new Bombero(estrategia, decorador, siguiente);
        }

        public IHerramienta crearHerramienta()
        {
            return new Manguera();
        }

        public IVehiculo crearVehiculo()
        {
            return new Autobomba();
        }
    }
}
