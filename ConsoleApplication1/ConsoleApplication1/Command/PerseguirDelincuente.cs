﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Command
{
    public class PerseguirDelincuente : IOrden
    {
        public void Ejecutar()
        {
            Console.WriteLine("Persiguiendo al sospechoso!!!");
        }
    }
}