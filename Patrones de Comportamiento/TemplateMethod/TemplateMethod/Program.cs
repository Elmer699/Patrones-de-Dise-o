using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pan Blanco");
            Blanco blanco = new Blanco();
            blanco.HacerPanTemplateMethod();
            Console.WriteLine("Pan Integral");
            Integral integral = new Integral();
            integral.HacerPanTemplateMethod();
        }
    }
}
