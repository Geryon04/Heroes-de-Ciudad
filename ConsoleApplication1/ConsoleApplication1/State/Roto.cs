using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;

namespace ConsoleApplication1.State
{
    public class Roto : EstadoDelMotor
    {
        public Roto(IVehiculo vehiculo) : base(vehiculo)
        {
        }
        public override void Arreglar()
        {
            Console.WriteLine("El motor ha sido reparado");
            vehiculo.CambiarEstado(new Apagado(vehiculo));
        }
    }
}
