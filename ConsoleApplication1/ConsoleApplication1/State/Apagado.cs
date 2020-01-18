using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;


namespace ConsoleApplication1.State
{
    public class Apagado : EstadoDelMotor
    {
        public Apagado(IVehiculo vehiculo) : base(vehiculo)
        {
        }

        public override void Encender()
        {
            Console.WriteLine("Encendido pero quieto");
            vehiculo.CambiarEstado(new PuntoMuerto(vehiculo));
        }
    }
}
