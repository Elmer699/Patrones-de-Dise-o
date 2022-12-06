using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyJuegoPrueba
{
    internal class Esperar : IEstrategiaJuego
    {
        public void jugar(int CantidadVida)
        {
            Console.WriteLine("Esperar aliados");
            Console.WriteLine(" La cantidad de vida es: " + CantidadVida + " HP");
        }
    }
}
