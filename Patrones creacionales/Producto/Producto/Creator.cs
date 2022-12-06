using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var producto = FactoryMethod();
            var resultado = "" + producto.Operacion();

            return resultado;
        }


        //public IProduct product;

        //public Creator(IProduct product)    
        //{
        //    this.product = product;
        //}
    }
}
