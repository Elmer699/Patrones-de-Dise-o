using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptador : IAdaptador
    {
        CajaEuros cajaEuros = new CajaEuros();
        public Adaptador()
        {

        }
        public double getSaldo()
        {
            return this.cajaEuros.getTotalEuros();
        }
        public void ingresarPesetas(double pesetas)
        {
            double euros = pesetas / 166.386;
            cajaEuros.ingresarEuros(euros);
        }

        public void sacarPeseta(double pesetas)
        {
            double euros = pesetas / 166.386;
            cajaEuros.ingresarEuros(euros);
        }
    }
}
