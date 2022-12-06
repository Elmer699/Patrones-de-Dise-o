using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Gasolina : IMotor
    {
        public void ConsumirCombustible()
        {
            RealizarCombustion();
        }

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de gasolina");
        }
 
        public void RealizarCombustion()
        {
            Console.WriteLine("Realizar la explosion de gasolina");
        }
    }
}
