using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    internal class FaseDios : Estado
    {
        public override void ControladordeEstado(Transformacion transformacion)
        {
            transformacion.DefinirEstado(new FaseBlue());
        }

        public override string Descripcion()
        {
            return "Super Sayayin Dios";
        }
    }
}
