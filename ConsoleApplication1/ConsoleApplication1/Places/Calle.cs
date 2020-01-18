using System;
namespace MetoIntegrador.Places
{
    public class Calle 
    {
        private int _longuitud;
        private int _cantidadDeFarolas;
        private int _cantidadDeCaudalPorMinuto;
        public Calle(){}

        public Calle(int longuitud, int cantidadDeFarolas, int cantidadDeCaudalPorMinuto)
        {
            _longuitud = longuitud;
            _cantidadDeFarolas = cantidadDeFarolas;
            _cantidadDeCaudalPorMinuto = cantidadDeCaudalPorMinuto;
        }

        public int Longuitud { get { return _longuitud;} set { _longuitud = value;} }
        public int CantidadDeFarolas { get { return _cantidadDeFarolas;} set {_cantidadDeFarolas = value;} }
        public int CantidadDeCaudalPorMinuto { get { return _cantidadDeCaudalPorMinuto; } set { _cantidadDeCaudalPorMinuto = value; } }

        public void RevisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las luces de la calle por luces led");
        }

    }
}