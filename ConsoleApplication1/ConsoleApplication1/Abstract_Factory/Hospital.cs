using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
   public class Hospital : ICuartel
    {
        private static Hospital unicoHospital = null;
        private IVehiculo vehiculos { get; set; }
        //private List<IVehiculo> vehiculos { get; set; }
        private Medico personal { get; set; }
        //private List<IResponsable> personal { get; set; }
        private IHerramienta herramientas { get; set; }
        //private List<IHerramienta> herramientas { get; set; }
        //private int aux = 0;
        private Hospital()
        {

        }
        public static Hospital getInstancia()
        {
            if(unicoHospital == null)
            {
                unicoHospital = new Hospital();
            }
            return unicoHospital;
        }
        public void agregarHerramienta(IHerramienta herramienta)
        {
            //herramientas.Add(herramienta);
            herramientas = herramienta;
        }

        public void agregarPersonal(IResponsable responsable)
        {
            //personal.Add(responsable);
            personal = (Medico)responsable;
        }

        public void agregarVehiculo(IVehiculo vehiculo)
        {
            //vehiculos.Add(vehiculo);
            vehiculos = vehiculo;
        }

        public IResponsable getPersonal()
        {
            
            Medico actual = personal;
            actual.Herramienta = herramientas;
            actual.Vehiculo = vehiculos;
            //aux++;
            return actual;
        }
    }
}
