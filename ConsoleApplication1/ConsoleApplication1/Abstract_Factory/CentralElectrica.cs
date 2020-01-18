using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Iterator;
using MetoIntegrador.Hero;

namespace ConsoleApplication1.Abstract_Factory
{
    public class CentralElectrica : ICuartel
    {
        private static CentralElectrica unicaCentral = null;
        private IVehiculo vehiculos { get; set; }
        //private List<IVehiculo> vehiculos { get; set; }
        
        private Electricista personal { get; set; }
        //public List<Electricista> personal { get; set; }
        private IHerramienta herramientas { get; set; }
        //private List<IHerramienta> herramientas { get; set; }
        //private int aux = 0;
        private CentralElectrica()
        {

        }

        public static CentralElectrica getInstancia()
        {
            if(unicaCentral == null)
            {
                unicaCentral = new CentralElectrica();
            }
            return unicaCentral;
        }
        public void agregarHerramienta(IHerramienta herramienta)
        {

            //herramientas.Add(herramienta);
            herramientas = herramienta;
        }

        public void agregarPersonal(IResponsable responsable)
        {
            personal = (Electricista)responsable;
        }

        public void agregarVehiculo(IVehiculo vehiculo)
        {
            //vehiculos.Add(vehiculo);
            vehiculos = vehiculo;
        }

        public IResponsable getPersonal()
        {

            Electricista actual = personal;
            actual.Herramienta = herramientas;
            actual.Vehiculo = vehiculos;
            //aux++;
            return actual;
        }
    }
}
