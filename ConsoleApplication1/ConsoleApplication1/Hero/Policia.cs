using ConsoleApplication1.Command;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;
using System;

namespace MetoIntegrador.Hero
{
    public class Policia : IResponsable
    {
        private IResponsable siguiente;
        public IOrden orden{get;set;}
        public IPatrullable patrullable { get; set; }

        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }
        public IResponsable Siguiente { get { return siguiente; } set { siguiente = value; } }
        public Policia(IOrden orden, IPatrullable patrullable, IResponsable responsable) : base(responsable)
        {
            this.orden = orden;
            this.patrullable = patrullable;
        }
        public override void PatrullarCalles(){
            vehiculo.encenderSirena();
            vehiculo.Conducir();
            herramienta.usar();
            if (patrullable.HayAlgoFueraDeLoComun())
            {
                DarAviso();
            }
            herramienta.Guardar();
            

        }
        public void DetenerDelicuente(){
            orden.Ejecutar();
        }

        public void DarAviso()
        {
            orden.Ejecutar();
        }
    }
}