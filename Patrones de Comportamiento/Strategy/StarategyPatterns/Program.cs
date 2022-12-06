using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarategyPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcesadorTexto texto = new ProcesadorTexto();
            texto.SeleccionaFormatoSalida(FormatoSalida.formatoNumerico);
            texto.setEstrategia(new[] { "Juan", "Juan", "miki" });

            Console.WriteLine(texto.ToString());
        }
    }
}
