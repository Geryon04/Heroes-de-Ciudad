using System;
using MetoIntegrador.Places;

namespace MetoIntegrador
{
    public class Escalera : IStrategy
    {
        public void ApagarIncendio(ILugar l, Calle c)
        {
        Console.WriteLine("Strategia escalera");
            }
        }
}
