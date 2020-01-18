using ConsoleApplication1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Factory_Method
{
   public abstract class FactorySectores : Sector 
    {
        // Sin Decorados = 0
        // Dia Lluvioso = 1
        // Dia de Calor = 2
        // Dia Ventoso  = 3
        // Grandes Arboles = 4
        // Gente Asustada = 5
        // Pasto Seco = 6
        //public enum Decorados
        //{
        //    SinDecorados, DiaLluvioso, DiaDeCalor, DiaVentoso, GrandesArboles, GenteAsustada, PastoSeco
        //}
        public static FactorySectores crearSector(int numeroDecorator /*Sector sector*/)
        {
            FactorySectores fab = null;
            switch (numeroDecorator)
            {
                case (1):
                    fab = new FactoryDiaLluvioso();
                    break;
                case (2):
                    fab = new FactoryDiaDeCalor();
                    break;
                case (3):
                    fab = new FactoryDiaVentoso();
                    break;
                case (4):
                    fab = new FactoryGrandesArboles();
                    break;
                case (5):
                    fab = new FactoryGenteAsustada();
                    break;
                case (6):
                    fab = new FactoryPastoSeco();
                    break;
                default:
                    fab = new FactorySinDecorados();
                    break;
            }

           
            return fab;

        }

        public abstract ISector crearSector(Sector s);
    }
}
