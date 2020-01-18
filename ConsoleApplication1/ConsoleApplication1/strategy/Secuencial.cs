using ConsoleApplication1.Decorator;
using MetoIntegrador.Places;
using System;
namespace MetoIntegrador
{
    public class Secuencial : IStrategy
    {
        public void ApagarIncendio(ILugar l, Calle c)
        {
            Sector[][] mapa = l.GetSectores();
            int N = mapa.Length;
            for (int x = 0; x < N; x++) {
                for (int y = 0; y < N; y++) {
                    Sector actual = mapa[x][y];
                    Console.Write("({0},{1})", x + 1, y + 1);

                    while (!actual.estaApagado()) 
                    {
                        
                            //mapa[x][y] = new Sector((mapa[x][y].afectacionDelFuego - c.CantidadDeCaudalPorMinuto).afectacionDelFuego >= 0 ? (mapa[x][y].afectacionDelFuego - c.CantidadDeCaudalPorMinuto) : 0);
                            Console.Write("->" + actual.afectacionDelFuego);
                            mapa[x][y] = new Sector(mapa[x][y].afectacionDelFuego - c.CantidadDeCaudalPorMinuto);
                            actual = mapa[x][y];
                            
                        
                        
                    } 
                        Console.WriteLine("");
                }
            }

            Console.WriteLine("¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad !!!!!!" , l.ToString());
        }
    }
}