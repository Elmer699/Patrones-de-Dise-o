using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyJuegoPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador jugador = new Jugador();
            jugador.jugar(100);
            //Tenemos Primera
            jugador.setIEstrategiaJuego(new Atacar());
            jugador.jugar(80);

            jugador.setIEstrategiaJuego(new Defender());
            jugador.jugar(30);
        }
    }
}
