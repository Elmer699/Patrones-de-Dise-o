using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pieza pieza = new Pieza();
            pieza._tipoPieza = tipoPieza.Reina;
            pieza.posicion = "E4";
            pieza.color = "Blanco";
            Console.WriteLine("La pieza es de tipo: " + pieza._tipoPieza);
            Console.WriteLine("La pocision de la pieza es: " + pieza.posicion);
            Console.WriteLine("La Pieza es de color: " + pieza.color);
            
        }
    }
}
