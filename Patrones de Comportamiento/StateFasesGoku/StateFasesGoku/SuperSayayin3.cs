using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    internal class SuperSayayin3 : Estado
    {
        public override void ControladordeEstado(Transformacion transformacion)
        {
            transformacion.DefinirEstado(new FaseDios());
        }

        public override string Descripcion()
        {
            return "Super Sayayin 3";
        }
    }
}
