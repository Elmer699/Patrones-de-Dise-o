using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class IteradorConcreto : Iterador
    {
        private AgregadoConcreto agregado;

        private int posicion_actual = 0;

        public IteradorConcreto(AgregadoConcreto agregado)
        {
            this.agregado = agregado;
        }

        public Object primero()
        {
            Object obj = null;
            if (this.agregado.aDatos.Any())
            {
                this.posicion_actual = 0;
                obj = this.agregado.aDatos.First();
            }
            return obj;
        }
        public Object siguiente()
        {
            Object obj = null;
            if ((this.posicion_actual) < this.agregado.aDatos.Count())
            {
                obj = this.agregado.aDatos.ElementAt(this.posicion_actual);
                this.posicion_actual = this.posicion_actual + 1;
            }
            return obj;
        }
        public bool hayMas()
        {
            bool obj = false;
            if (this.posicion_actual < (this.agregado.aDatos.Count()))
            {
                obj = true;
            }
            return obj;
        }
        public Object actual()
        {
            Object obj = null;
            if (this.posicion_actual < (this.agregado.aDatos.Count()))
            {
                obj = this.agregado.aDatos.ElementAt(this.posicion_actual);
            }
            return obj;
        }

        

       
    }
}
