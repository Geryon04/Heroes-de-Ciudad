using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Template_Method;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Proxy
{
   public class MedicoProxy : IResponsable
    {
        private FabricaMedico fabrica { get; set; }
        private Medico medicoReal = null;
        private IHerramienta herramienta;
        private IVehiculo vehiculo;
        TemplateMethod templateMethod = new RealizarRCP();
        private IResponsable siguiente { get; set; }
        public MedicoProxy(IResponsable responsable) : base(responsable)
        {
            siguiente = responsable;
        }

        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }

        public override void AtenderInfarto(IInfartable transeunte)
        {
            if (medicoReal == null)
            {
                fabrica = new FabricaMedico(siguiente);
                medicoReal = (Medico)fabrica.crearHeroe();
                medicoReal.Herramienta = fabrica.crearHerramienta();
                medicoReal.Vehiculo = fabrica.crearVehiculo();
            }
            medicoReal.AtenderInfarto(transeunte);
        }
        public void AtenderDesmayo()
        {
            Console.WriteLine("Atendiendo desmayo");
        }
    }
}
