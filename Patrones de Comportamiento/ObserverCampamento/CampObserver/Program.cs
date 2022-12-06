using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docente docente = new Docente(false);

            Camp camp = new Camp("Ronal", true);
            docente.Agregar(camp);
            docente.Notificar();
        }
    }
}
