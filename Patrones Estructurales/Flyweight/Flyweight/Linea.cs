using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Linea : ILineaLigera
    {
        private string color;
        public Linea(string color)
        {
            this.color = color;
        }
        public void dibujar(int col, int fila)
        {
            Console.WriteLine("Dibujando línea de color [" + this.color + "] en [" + col + ", " + fila + "]");
        }

        public string getColor()
        {
            return this.color;
        }
    }
}
