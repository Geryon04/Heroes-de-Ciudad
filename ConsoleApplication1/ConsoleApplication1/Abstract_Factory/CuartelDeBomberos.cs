using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class CuartelDeBomberos : ICuartel
    {
        private static CuartelDeBomberos unicoCuartel = null;
        private IVehiculo vehiculos { get; set; }
        //private List<IVehiculo> vehiculos { get; set; }
        private Bombero personal { get; set; }
        //private List<IResponsable> personal { get; set; }
        private IHerramienta herramientas { get; set; }
        //private List<IHerramienta> herramientas { get; set; }
        //private int aux = 0;
        private CuartelDeBomberos()
        {

        }
        public static CuartelDeBomberos getInstancia()
        {
            if (unicoCuartel == null)
            {
                unicoCuartel = new CuartelDeBomberos();
            }
            return unicoCuartel;
        }
        public void agregarHerramienta(IHerramienta herramienta)
        {
            //herramientas.Add(herramienta);
            herramientas = herramienta;
        }

        public void agregarPersonal(IResponsable responsable)
        {
            //personal.Add(responsable);
            personal = (Bombero)responsable;
        }

        public void agregarVehiculo(IVehiculo vehiculo)
        {
            //vehiculos.Add(vehiculo);
            vehiculos = vehiculo;
        }

        public IResponsable getPersonal()
        {
            
            Bombero actual = personal;
            actual.Herramienta = herramientas;
            actual.Vehiculo = vehiculos;
            //aux++;
            return actual;
        }
    }
}
