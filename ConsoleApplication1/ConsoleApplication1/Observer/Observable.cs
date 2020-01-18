using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Observer
{
    public interface Observable
    {
        void remover(Observer observer);
        void agregar(Observer observer);
        void notificar();
    }
}
