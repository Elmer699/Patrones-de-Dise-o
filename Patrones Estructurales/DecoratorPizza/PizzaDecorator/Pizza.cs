using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public abstract class Pizza
    {
        protected double Precio;
        public virtual double GetPrecio()
        {
            return this.Precio;
        }
    }
}
