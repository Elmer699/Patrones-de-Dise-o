using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampObserver
{
    public class Camp : ICamp
    {
        private string nombre;
        private bool Noticia;

        public Camp(string nombre, bool noticia)
        {
            this.nombre = nombre;
            this.Noticia = noticia;
        }

        public void Update(Docente docente)
        {
            if (docente.Noticias != Noticia)
            {
                Console.WriteLine("Ingeniera " + nombre + " Los estudiantes fueron al campamento");
            }
            else
            {
                Console.WriteLine("No fueron al campamento");
            }
        }
    }
}
