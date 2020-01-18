using System;
using System.Collections;
using ConsoleApplication1.Iterator;
using ConsoleApplication1.Builder;
using MetoIntegrador.Hero;
using MetoIntegrador.Places;
using ConsoleApplication1.Composite;
using ConsoleApplication1.Decorator;
using ConsoleApplication1.Command;
using ConsoleApplication1.Template_Method;
using ConsoleApplication1.Factory_Method;
using HeroesDeCiudad;
using ConsoleApplication1.Adapter;
using ConsoleApplication1.Chain_Of_Responsability;
using ConsoleApplication1.Abstract_Factory;
using ConsoleApplication1.Proxy;

namespace MetoIntegrador
{
    public class HeroesDeCiudad
    {
        static public void Main(string[] args) {

            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("1) Strategy");
            Console.WriteLine("2) Observer");
            Console.WriteLine("3) Composite");
            Console.WriteLine("4) Decorator");
            Console.WriteLine("5) Command");
            Console.WriteLine("6) Template Method");
            Console.WriteLine("7) Adapter");
            Console.WriteLine("8) Factory Method");
            Console.WriteLine("9) Builder");
            Console.WriteLine("10) Iterator");
            Console.WriteLine("11) Chain of Responsability");
            Console.WriteLine("12) Abstract Factory");
            Console.WriteLine("13) Singleton");
            Console.WriteLine("14) Proxy");
            Console.WriteLine("15) State");

            int eleccion = int.Parse(Console.ReadLine());


            switch (eleccion)
            {
                case 1:
                    PatronStrategy();
                    break;
                case 2:
                    patronObserver();
                    break;
                case 3:
                    PatronComposite();
                    break;
                case 4:
                    PatronDecorator();
                    break;
                case 5:
                    PatronCommand();
                    break;
                case 6:
                    PatronTemplateMethod();                  
                    break;
                case 7:
                    PatronAdapter();
                    break;
                case 8:
                    PatronFactoryMethod();
                    break;
                case 9:
                    PatronBuilder();
                    break;
                case 10:
                    PatronIterator();
                    break;
                case 11:
                    PatronChainOfResponsability();
                    break;
                case 12:
                    PatronAbstractFactory();
                    break;
                case 13:
                    PatronSingleton();
                    break;
                case 14:
                    PatronProxy();
                    break;
                case 15:
                    PatronState();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }




            Console.ReadKey();
        }

        public static ICuartel crearHeroe(IFabricaDeHeroes fabrica)
        {
            ICuartel cuartel = fabrica.crearCuartel();
            cuartel.agregarPersonal(fabrica.crearHeroe());
            cuartel.agregarHerramienta(fabrica.crearHerramienta());
            cuartel.agregarVehiculo(fabrica.crearVehiculo());
            return cuartel;
            
        }

        public static void PatronStrategy()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(410, 9, 12,director,builder);
            Decorator pasto = new PastoSeco(casa.crearSector(1, 15, 10));
            Calle calle = new Calle(12, 12, 100);
            IResponsable responsable = null;
            FabricaBombero FBombero = new FabricaBombero(estrategia, pasto, responsable);


            crearHeroe(FBombero).getPersonal().ApagarIncendio(casa, calle);
            
        }
        public static void patronObserver()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(410, 9, 12,director,builder);
            Decorator pasto = new PastoSeco(casa.crearSector(1, 15, 10));
            IResponsable responsable = null;
            FabricaBombero FBombero = new FabricaBombero(estrategia, pasto, responsable);
            ICuartel cuartel = crearHeroe(FBombero);
            Calle calle = new Calle(12, 12, 20);

            casa.Calle = calle;
            casa.agregar((Bombero)cuartel.getPersonal());
            casa.Chispa();


        }
        public static void PatronComposite()
        {
            IResponsable responsable = null;
            Electricista electricista = new Electricista(responsable);
            FabricaElectricista FElectricista = new FabricaElectricista(electricista);
            ICuartel cuartel = crearHeroe(FElectricista);
            Esquina e1 = new Esquina();
            Esquina e2 = new Esquina();
            Esquina e3 = new Esquina();

            Composite c1 = new Composite();
            Composite c2 = new Composite();
            Composite c3 = new Composite();

            c1.agregar(e1);
            c1.agregar(e2);
            c2.agregar(e3);
            c3.agregar(c2);
            c3.agregar(c1);

            cuartel.getPersonal().Revisar(c3);
        }
        public static void PatronDecorator()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(10, 9, 12, director, builder);
            Calle calle = new Calle(10, 12, 10);
            IResponsable responsable = null;
            Decorator pastoSeco = new PastoSeco(casa.crearSector(10, 10, 10));
            FabricaBombero FBombero = new FabricaBombero(estrategia, pastoSeco, responsable);

            ICuartel cuartel = crearHeroe(FBombero);
            cuartel.getPersonal().ApagarIncendio(casa, calle);

        }
        public static void PatronCommand()
        {
            Casa casa = new Casa();
            IOrden aviso = new VozDeAlto();
            IResponsable respo = null;
            FabricaPolicia fabrica = new FabricaPolicia(aviso, casa, respo);
            ICuartel cuartel = crearHeroe(fabrica);

            cuartel.getPersonal().PatrullarCalles();
        }
        public static void PatronTemplateMethod()
        {
            Transeunte transeunte = new Transeunte();
            IResponsable re = null;
            FabricaMedico medico = new FabricaMedico(re);
            ICuartel cuartel = crearHeroe(medico);
            cuartel.getPersonal().AtenderInfarto(transeunte);
        }
        public static void PatronAdapter()
        {
            
            Passerby extranjero = new Passerby(30, 30, 30);
            IInfartable transeunte = new Adapter(extranjero);
            
            IResponsable re = null;
            FabricaMedico medico = new FabricaMedico(re);
            ICuartel cuartel = crearHeroe(medico);
            cuartel.getPersonal().AtenderInfarto(transeunte);
        }
        public static void PatronFactoryMethod()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(10, 9, 12, director, builder);
            Calle calle = new Calle(10, 12, 10);
            IResponsable responsable = null;
            
            Decorator pastoSeco = new PastoSeco(FactorySectores.crearSector(1));
            FabricaBombero FBombero = new FabricaBombero(estrategia, pastoSeco, responsable);

            ICuartel cuartel = crearHeroe(FBombero);
            cuartel.getPersonal().ApagarIncendio(casa, calle);

        }
        public static void PatronBuilder()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(410, 9, 12, director, builder);
            Decorator pasto = new PastoSeco(casa.crearSector(1, 15, 10));
            Calle calle = new Calle(12, 12, 100);
            IResponsable responsable = null;
            FabricaBombero FBombero = new FabricaBombero(estrategia, pasto, responsable);


            crearHeroe(FBombero).getPersonal().ApagarIncendio(casa, calle);
        } 
        public static void PatronIterator()
        {
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(10, 10, 10, director, builder);
            casa.Superficie = 4;
            casa.Calle = new Calle(10, 10, 5);
            IStrategy estrategia = new Secuencial();
            Decorator pasto = new PastoSeco(casa.crearSector(10, 10, 10));
            IResponsable responsable = null;
            FabricaBombero fabrica = new FabricaBombero(estrategia, pasto, responsable);
            
            BomberoSecretario bombero = new BomberoSecretario();
            bombero.bombero.Herramienta = fabrica.crearHerramienta();
            bombero.bombero.Vehiculo = fabrica.crearVehiculo();
            DenunciaPorTablero tablero = new DenunciaPorTablero();
            casa.agregar(tablero);
            casa.Chispa();
            casa.Chispa();
            bombero.atenderdenuncias(tablero);
        }
        public static void PatronChainOfResponsability()
        {
            Casa casa = new Casa();
            IOrden aviso = new VozDeAlto();
            IInfartable transeunte = new Transeunte();
            IIluminable esquina = new Esquina(10);



            DenunciaDeInfarto infarto = new DenunciaDeInfarto(transeunte);
            DenunciaDeRobo robo = new DenunciaDeRobo(casa);
            DenunciaDeLamparaQuemada lampara = new DenunciaDeLamparaQuemada(esquina);
            MensajeWhatsapp mensaje = null;
            mensaje = new MensajeWhatsapp(infarto, mensaje);
            mensaje = new MensajeWhatsapp(robo, mensaje);
            mensaje = new MensajeWhatsapp(lampara, mensaje);
            DenunciaPorWhatsapp denunciaWhatsapp = new DenunciaPorWhatsapp(mensaje);

            IResponsable resposable = null;
            
            FabricaMedico Fmedico = new FabricaMedico(resposable);
            FabricaPolicia Fpolicia = new FabricaPolicia(aviso, casa, resposable);
            FabricaElectricista Felectricista = new FabricaElectricista(resposable);

            ICuartel cuartelEle = crearHeroe(Felectricista);
            ICuartel cuartelPo = crearHeroe(Fpolicia);
            ICuartel cuartelMe = crearHeroe(Fmedico);

            resposable = cuartelMe.getPersonal();
            resposable = cuartelPo.getPersonal();
            resposable = cuartelEle.getPersonal();

            Operador911 operador = new Operador911(resposable);
            operador.atenderDenuncias(denunciaWhatsapp);
        }
        public static void PatronAbstractFactory()
        {
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(10, 4, 12, director, builder);
            IStrategy estrategia = new Secuencial();
            Decorator pasto = new PastoSeco(casa.crearSector(10, 10, 10));
            Transeunte persona = new Transeunte();
            Esquina esquina = new Esquina(12);
            IResponsable responsable = null;
            responsable = new Electricista(responsable);
            FabricaElectricista FElectricista = new FabricaElectricista(responsable);
            FabricaBombero FBombero = new FabricaBombero(estrategia, pasto, responsable);

            crearHeroe(FElectricista).getPersonal().Revisar(esquina);
            crearHeroe(FBombero);
        }
        public static void PatronSingleton()
        {
            IStrategy estrategia = new Secuencial();
            Director director = new Director();
            var builder = new BuilderFavorable();
            Casa casa = new Casa(410, 9, 12, director, builder);
            Decorator pasto = new PastoSeco(casa.crearSector(1, 15, 10));
            IResponsable responsable = null;
            FabricaBombero fabrica = new FabricaBombero(estrategia,pasto,responsable);
            crearHeroe(fabrica);
            CuartelDeBomberos cb = CuartelDeBomberos.getInstancia();
            //cb.agregarHerramienta(fabrica.crearHerramienta());
            //cb.agregarVehiculo(fabrica.crearVehiculo());

            IResponsable b1 = cb.getPersonal();
            IResponsable b2 = cb.getPersonal();
            IResponsable b3 = cb.getPersonal();
            IResponsable b4 = cb.getPersonal();
            Console.WriteLine("El patron funciono");
        }
        public static void PatronProxy()
        {
            Esquina esquina = new Esquina(12);
            IResponsable responsable = null;
            responsable = new ElectricistaProxy(responsable);
            FabricaElectricista FElectricista = new FabricaElectricista(responsable);

            crearHeroe(FElectricista).getPersonal().Revisar(esquina);
        }
        public static void PatronState()
        {
            Esquina esquina = new Esquina(12);
            IResponsable responsable = null;
            responsable = new ElectricistaProxy(responsable);
            FabricaElectricista FElectricista = new FabricaElectricista(responsable);

            crearHeroe(FElectricista).getPersonal().Revisar(esquina);
        }

    }
}