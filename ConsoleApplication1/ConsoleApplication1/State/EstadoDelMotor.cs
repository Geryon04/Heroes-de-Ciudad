using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Abstract_Factory;

namespace ConsoleApplication1.State
{
    public abstract class EstadoDelMotor
    {
        protected IVehiculo vehiculo { get; set; }

        public EstadoDelMotor(IVehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }
        public virtual void Acelerar()
        {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void Apagar()
        {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void Encender()
        {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void Desacelerar()
        {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void Arreglar()
        {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void Frenar()
        {
            Console.WriteLine("Sin Efecto");
        }

    }
}
