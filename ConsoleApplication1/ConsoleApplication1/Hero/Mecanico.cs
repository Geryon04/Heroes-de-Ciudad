using System;
using ConsoleApplication1.Iterator;
namespace MetoIntegrador.Hero
{
    public class Mecanico : IResponsable
    {
        public Mecanico(IResponsable responsable) : base(responsable)
        {
        }

        public void ArreglarMotor(){
            Console.WriteLine("Arreglando motor");
        }
        public void RemolcarAuto(){
            Console.WriteLine("Remolcando auto");
        }

    }
}