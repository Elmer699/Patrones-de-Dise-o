using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class Singleton
    {
        public DateTime fechaHora { get; set; }
        private Singleton() { }


        public static Singleton instanciaReloj = new Singleton();


        public static Singleton InstanciaReloj()
        {
            if (instanciaReloj == null)
            {
                instanciaReloj = new Singleton();
                instanciaReloj.fechaHora = DateTime.Now;
            }            
            return instanciaReloj;
        }
    }
}
