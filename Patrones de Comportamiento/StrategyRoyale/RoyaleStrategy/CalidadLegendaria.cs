using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleStrategy
{
    public class CalidadLegendaria : ITipoCalidad
    {
        public void contenido(StringBuilder sb, string item)
        {
            sb.AppendLine(item);
        }

        public void etiquetaCierre(StringBuilder sb)
        {
            sb.AppendLine("-----------------------");
        }

        public void etquetaApertura(StringBuilder sb)
        {
            sb.AppendLine("-----------------------");
            sb.AppendLine("Calidad Legendaria");
        }
    }
}
