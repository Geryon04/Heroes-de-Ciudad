using ConsoleApplication1.Command;
using ConsoleApplication1.Decorator;
using ConsoleApplication1.Observer;
using System;
using System.Collections.Generic;
using ConsoleApplication1.Builder;

namespace MetoIntegrador.Places
{
    public class Plaza : ILugar, Observable, IPatrullable
    {
        #region properties
            private string _nombre;
            private int _superficie;
            private int _cantidadDeArboles;
            private int _cantidadDeFarolas;
            private Calle _calle;
            private Director director;
            private AbstractBuilder constructor;
            private List<Observer> _listObserver = new List<Observer>();

        

        public Calle Calle { get {return _calle;} set { _calle = value;} }
            public string Nombre { get {return _nombre;} set { _nombre = value;} }
            public int Superficie { get { return _superficie;} set { _superficie = value;} }
            public int CantidadDeArboles { get { return _cantidadDeArboles;} set { _cantidadDeArboles = value;} }
            public int CantidadDeFarolas { get { return _cantidadDeFarolas; } set { _cantidadDeFarolas = value; } }
            public Director Director { get { return director; } set { this.director = value; } }
            public AbstractBuilder Constructor { get { return constructor; } set { constructor = value; } }

        #endregion

        public Plaza(int superficie, int cantidadDeArboles, int cantidadDeFarolas, Calle calle, Director director, AbstractBuilder constructor)
        {
            _superficie = superficie;
            _cantidadDeArboles = cantidadDeArboles;
            _cantidadDeFarolas = cantidadDeFarolas;
            _calle = calle;
            this.director = director;
            this.constructor = constructor;
        }

        public void Chispa()
        {
            Console.WriteLine("Hacer sonar la alarma de incendio");
           //this.Notify();
        }

        public Sector[][] GetSectores()
        {
            Random r = new Random();
            double raiz = Math.Sqrt(this.Superficie);
            int N = (int)Math.Round(raiz);
            Sector[][] sector = Director.crearSector(constructor, N);
            //Random r = new Random();
            //double raiz = Math.Sqrt(this.Superficie);
            //int N =(int) Math.Round(raiz);
            //Sector [][] sectores= new Sector[N][];
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
            return "la Plaza";
        }

        public Calle GetCalle()
        {
            return this.Calle;
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

        public bool HayAlgoFueraDeLoComun()
        {
            double irregularidad = new Random().Next(101);
            return (irregularidad < 80) ? true : false;
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
    }
}