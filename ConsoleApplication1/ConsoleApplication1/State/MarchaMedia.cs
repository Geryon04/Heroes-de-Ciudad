using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;

namespace ConsoleApplication1.State
{
    public class MarchaMedia : EstadoDelMotor
    {
        public MarchaMedia(IVehiculo vehiculo) : base(vehiculo)
        {
        }
        public override void Desacelerar()
        {
            Console.WriteLine("Bajando la velocidad");
            vehiculo.CambiarEstado(new MarchaLenta(vehiculo));
        }
        public override void Frenar()
        {
            Console.WriteLine("Frenando el vehiculo");
            vehiculo.CambiarEstado(new PuntoMuerto(vehiculo));
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando");
            vehiculo.CambiarEstado(new ATodaVelocidad(vehiculo));
        }
        public override void Apagar()
        {
            Console.WriteLine("El motor se ha roto");
            vehiculo.CambiarEstado(new Roto(vehiculo));
        }
    }
}
