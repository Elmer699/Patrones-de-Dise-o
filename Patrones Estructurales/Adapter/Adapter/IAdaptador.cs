using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IAdaptador
    {
        void sacarPeseta(double pesetas);
        void ingresarPesetas(double pesetas);
    }
}
