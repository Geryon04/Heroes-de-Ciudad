using System;
using MetoIntegrador.Hero;
using ConsoleApplication1.Decorator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetoIntegrador;

namespace ConsoleApplication1.Iterator
{
   public class BomberoSecretario
    {
        public Bombero bombero { get; set; }
        
        
        public BomberoSecretario()
        {
            
            bombero = new Bombero(new Secuencial(), new DiaLluvioso(new Sector()),null);
           
        }

        //public BomberoSecretario
        public void atenderdenuncias(IDenuncias denuncias)
        {
            Iterator iter = denuncias.crearIterador();
            while (iter.hasNext())
            {
                DenunciaDeIncendio actual = (DenunciaDeIncendio)iter.Next();
                actual.atender(bombero);
            }
        }

    }
}
