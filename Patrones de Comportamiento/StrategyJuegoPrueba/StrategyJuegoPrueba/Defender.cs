using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyJuegoPrueba
{
    internal class Defender : IEstrategiaJuego
    {
        public void jugar(int CantidadVida)
        {
            Console.WriteLine("Mantenerce en torre");
            Console.WriteLine(" La cantidad de vida es: " + CantidadVida + " HP");
        }
    }
}
