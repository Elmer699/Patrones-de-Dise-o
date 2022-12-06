using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    internal class UltraInstinto : Estado
    {
        public override void ControladordeEstado(Transformacion transformacion)
        {
            transformacion.DefinirEstado(new SuperSayayin1());
        }

        public override string Descripcion()
        {
            return "Ultra Instinto";
        }
    }
}
