﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutomovil automovil = new ProxyAutomovil("Jorge",true,19);

            Console.WriteLine(automovil.conducir());
        }
    }
}
