using ConsoleApplication1.Decorator;
using ConsoleApplication1.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    public class BuilderFavorable : AbstractBuilder
    {

        public BuilderFavorable() { }
      public override void decorarSector() {
            for (int i = 0; i < sector.Length; i++)
            {
                sector[i] = new Sector[sector.Length];
                for (int j = 0; j < sector.Length; j++)
                {
                    //sectores[i][j] = r.Next(101);
                    //sectores[i][j] = new Sector(r.Next(101));
                    sector[i][j] = FactorySectores.crearSector(1);
                }
            } 
            
      }

        
    }
}
