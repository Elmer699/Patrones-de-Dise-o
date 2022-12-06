using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    public class SuperSayayin1 : Estado
    {
        public override void ControladordeEstado(Transformacion transformacion)
        {
            transformacion.DefinirEstado(new SuperSayayin2());
        }

        public override string Descripcion()
        {
            return "Super Sayayin 1";
        }
    }
}
