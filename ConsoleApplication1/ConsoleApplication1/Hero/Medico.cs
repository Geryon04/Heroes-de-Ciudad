using ConsoleApplication1.Abstract_Factory;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Template_Method;
using System;

namespace MetoIntegrador.Hero
{
    public class Medico : IResponsable
    {
        private IHerramienta herramienta;
        private IVehiculo vehiculo;
        TemplateMethod templateMethod = new RealizarRCP();

        public Medico(IResponsable responsable) : base(responsable)
        {
        }

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }

        public override void AtenderInfarto(IInfartable transeunte){
            vehiculo.encenderSirena();
            vehiculo.Conducir();
            herramienta.usar();
            templateMethod.Method(transeunte);
            herramienta.Guardar();
        }
        public void AtenderDesmayo(){
            Console.WriteLine("Atendiendo desmayo");
        }
    }
}