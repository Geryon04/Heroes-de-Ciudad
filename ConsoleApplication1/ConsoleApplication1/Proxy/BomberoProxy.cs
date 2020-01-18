using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;
using ConsoleApplication1.Decorator;
using ConsoleApplication1.Observer;
using MetoIntegrador.Places;
using MetoIntegrador.Hero;
using MetoIntegrador;

namespace ConsoleApplication1.Proxy
{
    public class BomberoProxy : IResponsable
    {
        private FabricaBombero fabrica { get; set; }
        private Bombero bomberoReal = null;
        private IStrategy strategy;
        private Decorator.Decorator decorator;
        private Sector sector;
        private IHerramienta herramienta;
        private IVehiculo vehiculo;
        private IResponsable siguiente { get; set; }


        public BomberoProxy(IStrategy strategy, Decorator.Decorator decorator, IResponsable responsable) : base(responsable)
        {
            this.Strategy = strategy;
            this.Decorator = decorator;
            siguiente = responsable;

        }

        public IStrategy Strategy { get { return strategy; } set { strategy = value; } }

        public Decorator.Decorator Decorator { get { return decorator; } set { decorator = value; } }
        public Sector Sector { get { return sector; } set { sector = value; } }
        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }

        public override void ApagarIncendio(ILugar lugar, Calle calle)
        {
            if (bomberoReal == null)
            {
                fabrica = new FabricaBombero(strategy, decorator, siguiente);
                bomberoReal = (Bombero)fabrica.crearHeroe();
                bomberoReal.Herramienta = fabrica.crearHerramienta();
                bomberoReal.Vehiculo = fabrica.crearVehiculo();
                
            }
            bomberoReal.ApagarIncendio(lugar,calle);

            
        }

        public void BajarGatitoDeArbol()
        {
            Console.WriteLine("Bajando gatito del arbol");
        }


        public void actualizar(Observable observado)
        {
            ApagarIncendio((ILugar)observado, ((ILugar)observado).GetCalle());
        }


    }
}
