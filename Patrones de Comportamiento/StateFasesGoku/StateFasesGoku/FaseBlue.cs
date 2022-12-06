using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    internal class FaseBlue : Estado
    {
        public override void ControladordeEstado(Transformacion transformacion)
        {
            transformacion.DefinirEstado(new UltraInstinto());
        }

        public override string Descripcion()
        {
            return "Super Sayayin Blue";
        }
    }
}
