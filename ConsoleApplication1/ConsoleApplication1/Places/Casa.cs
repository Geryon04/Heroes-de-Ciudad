 using System;
using System.Collections.Generic;
using MetoIntegrador;
using ConsoleApplication1.Observer;
using ConsoleApplication1.Decorator;
using ConsoleApplication1.Command;
using ConsoleApplication1.Builder;

namespace MetoIntegrador.Places
{
    public class Casa : ILugar, Observable, IPatrullable
    {
        #region  properties
        
        private int _numeroDePuerta;
        private int _superficie;
        private int _cantidadDeHabitantes;
        private List<Observer> _listObserver = new List<Observer>();
        private Director director;
        private AbstractBuilder constructor;
        
        private Calle _calle;
        public int NumeroDePuerta { get {return _numeroDePuerta;} set{_numeroDePuerta = value;} }
        public int Superficie { get {return _superficie; }set { _superficie = value;} }
        public int CantidadDeHabitantes { get {return _cantidadDeHabitantes;} set { _cantidadDeHabitantes = value;} }
        public Calle Calle { get { return _calle; } set { _calle = value; } }
        public Director Director { get { return director; } set { this.director = value; } }
        public AbstractBuilder Constructor { get { return constructor; } set { constructor = value; } }

        #endregion properties
        
        public Casa(int numeroDePuerta, int superficie, int cantidadDeHabitantes, Director director, AbstractBuilder constructor)
        {
            _numeroDePuerta = numeroDePuerta;
            _superficie = superficie;
            _cantidadDeHabitantes = cantidadDeHabitantes;
            this.director = director;
            this.constructor = constructor;
        }
        public Casa() { }

        public void Chispa()
        {
            Console.WriteLine("Hacer sonar la alarma de incendio");
            this.notificar();
           
        }

        public Sector[][] GetSectores()
        {
            Random r = new Random();
            double raiz = Math.Sqrt(this.Superficie);
            int N =(int) Math.Round(raiz);
            Sector[][] sector = Director.crearSector(constructor,N);
            //Sector [][] sectores= new Sector[N][];
            //Sector[][] sectores = Director.crearSector();
            //for (int i = 0; i < N; i++ ){
            //    sectores[i] = new Sector[N];
            //    for (int j = 0; j < N ; j++ ){
            //        //sectores[i][j] = r.Next(101);
            //        sectores[i][j] = new Sector(r.Next(101));
            //    }
            //}
            return sector;
        }

        override public string ToString(){
            return "la Casa";
        }

        public Calle GetCalle(){
            return this.Calle;
        }



        public void remover(Observer observer)
        {
            _listObserver.Remove(observer);
        }

        public void agregar(Observer observer)
        {
            _listObserver.Add(observer);
        }

        public void notificar()
        {
            foreach (Observer ob in _listObserver)
            {
                ob.actualizar(this);
            }
        }

        public bool HayAlgoFueraDeLoComun()
        {
            double irregularidad = new Random().Next(101);
            return (irregularidad < 80) ? true : false;
        }

        public Sector decorarSector(Sector sector, int caudalLluvia, int temperatura, int velocidadViento)
        {
            double random = new Random().NextDouble();
            double probabilidad_de_decorar = 0.2;
            if (random < probabilidad_de_decorar)
                sector = new PastoSeco(sector);
            if (random < probabilidad_de_decorar)
                sector = new ArbolesGrandes(sector);
            if (random < probabilidad_de_decorar)
                sector = new GenteAsustada(sector);
            if (temperatura > 30)
                sector = new DiaDeCalor(sector);
            if (velocidadViento > 80)
                sector = new DiaVentoso(sector);
            if (caudalLluvia > 0)
                sector = new DiaLluvioso(sector);
            return sector;
        }

        public Sector crearSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            int caudal = new Random().Next(100);
            Sector sector = new Sector(caudal);
            return decorarSector(sector, caudalLluvia, temperatura, velocidadViento);
        }
    }
}