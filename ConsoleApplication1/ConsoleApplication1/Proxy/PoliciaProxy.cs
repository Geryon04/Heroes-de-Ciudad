using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;
using MetoIntegrador.Hero;
using ConsoleApplication1.Command;

namespace ConsoleApplication1.Proxy
{
    public class PoliciaProxy : IResponsable
    {
        private FabricaPolicia fabrica { get; set; }
        private Policia policiaReal = null;
        public IOrden orden { get; set; }
        public IPatrullable patrullable { get; set; }
        private IHerramienta herramienta;
        private IVehiculo vehiculo;
        private IResponsable siguiente;

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }
        public IResponsable Siguiente { get { return siguiente; } set { siguiente = value; } }
        public PoliciaProxy(IOrden orden, IPatrullable patrullable, IResponsable responsable) : base(responsable)
        {
            this.orden = orden;
            this.patrullable = patrullable;
        }

        public override void PatrullarCalles()
        {
            if(policiaReal == null)
            {
                fabrica = new FabricaPolicia(orden, patrullable, siguiente);
                policiaReal = (Policia)fabrica.crearHeroe();
                policiaReal.Vehiculo = fabrica.crearVehiculo();
                policiaReal.Herramienta = fabrica.crearHerramienta();
            }
            policiaReal.PatrullarCalles();
        }
        public void DetenerDelicuente()
        {
            orden.Ejecutar();
        }

        public void DarAviso()
        {
            orden.Ejecutar();
        }
    }
}
