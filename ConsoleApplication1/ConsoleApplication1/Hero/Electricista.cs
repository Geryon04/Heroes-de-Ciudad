using ConsoleApplication1.Composite;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;
using System;
namespace MetoIntegrador.Hero
{
    public class Electricista : IResponsable
    {
        private IResponsable siguiente { get; set; }
        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        public Electricista(IResponsable responsable) : base(responsable)
        {
            siguiente = responsable;
        }

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }
        public override void Revisar(IIluminable i){
            vehiculo.encenderSirena();
            vehiculo.Conducir();
            herramienta.usar();
            i.revisarYCambiarLamparasQuemadas();
            herramienta.Guardar();
            
        }
    }
}