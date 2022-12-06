using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public abstract class Decorador : Pizza
    {
        protected Pizza _pizza;
        public Decorador(Pizza pizza)
        {
            this._pizza = pizza;
        }
        public override double GetPrecio()
        {
            return this._pizza.GetPrecio() + this.Precio;
        }
    }
}
