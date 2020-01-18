using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Composite;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Proxy
{
    public class ElectricistaProxy : IResponsable
    {
        private FabricaElectricista fabrica { get; set; }
        private Electricista electricistaReal = null;
        private IResponsable siguiente { get; set; }
        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        public ElectricistaProxy(IResponsable responsable) : base(responsable)
        {
            siguiente = responsable;
        }

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }
        public override void Revisar(IIluminable i)
        {
            if(electricistaReal == null)
            {
                fabrica = new FabricaElectricista(siguiente);
                electricistaReal = (Electricista)fabrica.crearHeroe();
                electricistaReal.Herramienta = fabrica.crearHerramienta();
                electricistaReal.Vehiculo = fabrica.crearVehiculo();
            }
            electricistaReal.Revisar(i);

        }
    }
}
