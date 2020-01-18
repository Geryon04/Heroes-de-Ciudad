using ConsoleApplication1.Factory_Method;
using ConsoleApplication1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{

    public class BuilderMixto : AbstractBuilder
    {
        public override void decorarSector()
        {
            for (int i = 0; i < sector.Length; i++)
            {
                sector[i] = new Sector[sector.Length];
                for (int j = 0; j < sector.Length; j++)
                {
                   if(j % 2 == 0)
                    {
                        sector[i][j] = FactorySectores.crearSector(1);
                    }
                    else
                    {
                        sector[i][j] = FactorySectores.crearSector(3);
                    }
                }
            }
           
        }
    }
}
