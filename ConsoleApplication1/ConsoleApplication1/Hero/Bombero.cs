using System;
using MetoIntegrador.Places;
using MetoIntegrador;
using ConsoleApplication1.Observer;
using ConsoleApplication1.Decorator;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Abstract_Factory;

namespace MetoIntegrador.Hero
{
    public class Bombero : IResponsable, Observer
    {
        private IStrategy strategy;
        private Decorator decorator;
        private Sector sector;
        private IHerramienta herramienta;
        private IVehiculo vehiculo;


        public Bombero(IStrategy strategy, Decorator decorator, IResponsable responsable):base(responsable)
        {
            this.Strategy = strategy;
            this.Decorator = decorator;

        }

        public IStrategy Strategy { get { return strategy; } set { strategy = value; } }

        public Decorator Decorator { get { return decorator; } set { decorator = value; } }
        public Sector Sector { get { return sector; } set { sector = value; } }
        public IHerramienta Herramienta { get { return herramienta; } set { herramienta = value; } }
        public IVehiculo Vehiculo { get { return vehiculo; } set { vehiculo = value; } }

        public override void ApagarIncendio(ILugar lugar, Calle calle){
            vehiculo.encenderSirena();
            vehiculo.Conducir();
            herramienta.usar();
            this.Decorator.SectorInterno.mojar(calle.CantidadDeCaudalPorMinuto);
           //s this.Sector.mojar(calle.CantidadDeCaudalPorMinuto);
            this.Strategy.ApagarIncendio(lugar,calle);
            herramienta.Guardar();
        }
        public void BajarGatitoDeArbol(){
            Console.WriteLine("Bajando gatito del arbol");
        }


        public void actualizar(Observable observado)
        {
            ApagarIncendio((ILugar)observado, ((ILugar)observado).GetCalle());
        }
    }
}