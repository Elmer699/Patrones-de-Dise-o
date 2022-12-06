using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class ConcretProduct2 : IProduct
    {
        public string Operacion()
        {
            return "Se devuelve Product 2";
        }
    }
}
