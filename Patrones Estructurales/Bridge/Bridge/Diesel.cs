using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Diesel : IMotor
    {
        public void ConsumirCombustible()
        {
            RealizarExplosion();
        }

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de diesel");
        }

        public void RealizarExplosion()
        {
            Console.WriteLine("Realizar la explosion de diesel");
        }
    }
}
