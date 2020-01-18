using ConsoleApplication1.Factory_Method;
using ConsoleApplication1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    public class BuilderDesfavorable : AbstractBuilder
    {
        public override void decorarSector()
        {
            for (int i = 0; i < sector.Length; i++)
            {
                sector[i] = new Sector[sector.Length];
                for (int j = 0; j < sector.Length; j++)
                {
                    //sectores[i][j] = r.Next(101);
                    //sectores[i][j] = new Sector(r.Next(101));
                    sector[i][j] = FactorySectores.crearSector(4);
                }
            }
            //FactorySectores.crearSector(2);
            //FactorySectores.crearSector(3);
            //FactorySectores.crearSector(4);
            //FactorySectores.crearSector(5);
            //FactorySectores.crearSector(6);
        }
    }
}
