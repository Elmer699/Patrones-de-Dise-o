using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Limon limon = new Limon(2.5);

            Restaurante restaurante = new Restaurante("Panchita" , 1);
            limon.Suscribe(restaurante);
            limon.Notificar();


        }
    }
}
