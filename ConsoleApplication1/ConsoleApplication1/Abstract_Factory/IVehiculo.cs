using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.State;

namespace ConsoleApplication1.Abstract_Factory
{
   public interface IVehiculo
    {
        void encenderSirena();
        void Conducir();
        void CambiarEstado(EstadoDelMotor estado);
    }
}
