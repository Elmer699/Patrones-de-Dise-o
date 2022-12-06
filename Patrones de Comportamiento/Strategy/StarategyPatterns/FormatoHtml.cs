using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarategyPatterns
{
    internal class FormatoHtml : IFormatoSalidaStrategy
    {
        public void etiquetaCierre(StringBuilder sb)
        {
            sb.AppendLine("<ul>");
        }
        public void contenido(StringBuilder sb, string item)
        {
            sb.AppendLine($"<li>{item}<li>");
        }
        public void etquetaApertura(StringBuilder sb)
        {
            sb.AppendLine("</ul>");
        }
    }
}
