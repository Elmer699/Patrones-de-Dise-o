﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo berlina = new Berlina(motorDiesel, 4);

            berlina.MostrarCaracteristicas();
        }
    }
}
