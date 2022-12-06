using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptador adaptador = new Adaptador();

            adaptador.ingresarPesetas(2000);
            adaptador.ingresarPesetas(5000);
            adaptador.ingresarPesetas(1000);

            Console.WriteLine("Total euros: " + adaptador.getSaldo());
        }
    }
}
