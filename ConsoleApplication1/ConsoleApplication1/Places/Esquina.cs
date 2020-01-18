using ConsoleApplication1.Composite;
using System;

namespace MetoIntegrador.Places
{
    public class Esquina : IIluminable
    {
        private int _cantidadDeSemaforo;

        public Esquina(){}
        public Esquina(int cantidadDeSemaforo)
        {
            _cantidadDeSemaforo = cantidadDeSemaforo;
        }

        public int CantidadDeSemaforo { get { return _cantidadDeSemaforo; } set { _cantidadDeSemaforo = value; } }
        
        
        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las luces de los semaforos");
        }
        


        
        public bool HayAlgoFueraDeLoNormal()
        {
            return new Random().Next(100) > 50 ? true : false;
        }
        
    }
}