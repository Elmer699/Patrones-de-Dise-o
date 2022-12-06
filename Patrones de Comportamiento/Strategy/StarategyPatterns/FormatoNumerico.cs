using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarategyPatterns
{
    internal class FormatoNumerico : IFormatoSalidaStrategy
    {
        public void etiquetaCierre(StringBuilder sb)
        {
            
        }
        public void contenido(StringBuilder sb, string item)
        {
            var numerico = Regex.Matches(item, "/n").Count + 1;
            sb.AppendLine($"{numerico} - {item}");
        }

        

        public void etquetaApertura(StringBuilder sb)
        {
        }
    }
}
