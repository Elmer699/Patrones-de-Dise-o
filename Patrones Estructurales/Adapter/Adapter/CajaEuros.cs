using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CajaEuros
    {
        private double euros = 0;
        public CajaEuros()
        {

        }
        public double getTotalEuros()
        {
            return this.euros;
        }
        public void sacarEuros(double euros)
        {
            this.euros -= euros;
        }
        public void ingresarEuros(double euros)
        {
            this.euros += euros;
        }
    }
}
