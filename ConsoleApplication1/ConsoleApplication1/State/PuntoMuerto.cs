using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;

namespace ConsoleApplication1.State
{
    public class PuntoMuerto : EstadoDelMotor
    {
        public PuntoMuerto(IVehiculo vehiculo) : base(vehiculo)
        {
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando el motor");
            vehiculo.CambiarEstado(new Apagado(vehiculo));
        }
        public override void Acelerar()
        {
            Console.WriteLine("Marchando a velocidad lenta");
            vehiculo.CambiarEstado(new MarchaLenta(vehiculo));
        }
    }
}
