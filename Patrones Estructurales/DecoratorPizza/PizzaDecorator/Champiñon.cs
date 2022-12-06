using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class Champiñon : Decorador
    {
        public Champiñon(Pizza pizza) : base(pizza)
        {
            this.Precio = 14;
        }
    }
}
