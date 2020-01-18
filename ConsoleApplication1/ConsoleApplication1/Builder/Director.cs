 using ConsoleApplication1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Builder
{
    public class Director
    {
        //public AbstractBuilder constructor { get; set; }
        

        public Sector[][] crearSector(AbstractBuilder constructor, int superficie)
        {
            constructor.crearSector(superficie);
            constructor.decorarSector();
                
            return constructor.obtenerSector();
        }

        
    }
}
