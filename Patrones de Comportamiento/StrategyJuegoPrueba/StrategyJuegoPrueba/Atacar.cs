using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyJuegoPrueba
{
    internal class Atacar : IEstrategiaJuego
    {

        public void jugar(int CantidadVida)
        {
            Console.WriteLine("Lanzar la primera y seguna habilidad");
            Console.WriteLine(" La cantidad de vida es: " + CantidadVida + " HP");
        }
    }
}
