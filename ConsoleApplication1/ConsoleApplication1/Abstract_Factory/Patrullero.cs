using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.State;

namespace ConsoleApplication1.Abstract_Factory
{
    public class Patrullero : IVehiculo
    {
        EstadoDelMotor estado { get; set; }
        public Patrullero()
        {
            estado = new Apagado(this);
        }
        public void Acelerar()
        {
            estado.Acelerar();
        }
        public void Desacelerar()
        {
            estado.Desacelerar();
        }
        public void Encender()
        {
            estado.Encender();
        }
        public void Apagar()
        {
            estado.Apagar();
        }
        public void Arreglar()
        {
            estado.Arreglar();
        }
        public void Frenar()
        {
            estado.Frenar();
        }
        public void CambiarEstado(EstadoDelMotor estado)
        {
            this.estado = estado;
        }

        public void Conducir()
        {
            //Console.WriteLine("Conduciendo un Patrullero");
            Encender();
            Acelerar();
            Acelerar();
            Desacelerar();
            Frenar();
            Apagar();
        }

        public void encenderSirena()
        {
            Console.WriteLine("Sirena de Policia");
        }
    }
}
