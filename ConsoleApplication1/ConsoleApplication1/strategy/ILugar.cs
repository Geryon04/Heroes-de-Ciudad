using ConsoleApplication1.Decorator;
using MetoIntegrador.Places;
namespace MetoIntegrador
{
    public interface ILugar
    {
        //int[][] GetSectores();
         Sector [][] GetSectores();
         void Chispa();
         Calle GetCalle();
    }
}