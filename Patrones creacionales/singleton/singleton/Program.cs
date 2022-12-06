using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.InstanciaReloj();
            Singleton s2 = Singleton.InstanciaReloj();

            Console.WriteLine(s1.fechaHora);
            Console.WriteLine(s2.fechaHora);
        }
    }
}
