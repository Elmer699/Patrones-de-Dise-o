using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class ConcretProduct : IProduct
    {
        public string Operacion()
        {
            return "Se devuelve el producto";
        }
    }
}
