using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Truck : ITransport
    {
        public string deliver()
        {
            return "En camino";
        }
    }
}
