using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Comisaria : ICuartel
    {
        private static Comisaria unicaComisaria = null;
        private IVehiculo vehiculos { get; set; }
        //private List<IVehiculo> vehiculos { get; set; }
        private Policia personal { get; set; }
        //private List<IResponsable> personal { get; set; }
        private IHerramienta herramientas { get; set; }
        //private List<IHerramienta> herramientas { get; set; }
        //private int aux = 0;
        private Comisaria()
        {

        }

        public static Comisaria getInstancia()
        {
            if(unicaComisaria == null)
            {
                unicaComisaria = new Comisaria();
            }
            return unicaComisaria;
        }
        public void agregarHerramienta(IHerramienta herramienta)
        {
            //herramientas.Add(herramienta);
            herramientas = herramienta;
        }

        public void agregarPersonal(IResponsable responsable)
        {
            //personal.Add(responsable);
            personal = (Policia)responsable;
        }

        public void agregarVehiculo(IVehiculo vehiculo)
        {
            //vehiculos.Add(vehiculo);
            vehiculos = vehiculo;
        }

        public IResponsable getPersonal()
        {
            
            Policia actual = personal;
            actual.Herramienta = herramientas;
            actual.Vehiculo = vehiculos;
            //aux++;
            return actual;
        }
    }
}
