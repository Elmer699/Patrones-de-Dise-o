using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    public abstract class Estado
    {
        public abstract void ControladordeEstado(Transformacion transformacion);
        public abstract string Descripcion();
    }
}
