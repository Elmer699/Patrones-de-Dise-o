using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyJuegoPrueba
{
    public class Jugador
    {
        private IEstrategiaJuego estrategia;

        public Jugador()
        {
            this.estrategia = new Esperar();
        }

        public void setIEstrategiaJuego(IEstrategiaJuego estrategiaJuego)
        {
            this.estrategia = estrategiaJuego;
        }
        public void jugar(int CantidadVida)
        {
            this.estrategia.jugar(CantidadVida);
        }
    }
}
