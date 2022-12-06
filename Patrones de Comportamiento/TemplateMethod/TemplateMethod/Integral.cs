using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Integral : Pan
    {
        public override void Hornear()
        {
            Console.WriteLine("Meter al horno po al menos unas 3 horas");
        }

        public override void MezclarIngredientes()
        {
            Console.WriteLine("Mezclar la haina con el huevo y leche");
        }
    }
}
