using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Iterator
{
    public class AgregadoConcreto : IAgregado
    {
        protected internal List<string> aDatos = new List<string>();
        // -------------------------
        public AgregadoConcreto()
        {
            this.llenar();
        }
        // -------------------------
        public Iterador getIterador()
        {
            return new IteradorConcreto(this);
        }
        // -------------------------
        public void llenar()
        {
            this.aDatos.Add("JOSE");
            this.aDatos.Add("MARTA");
            this.aDatos.Add("ANTONIO");
            this.aDatos.Add("ROMINA");
        }
    }
}
