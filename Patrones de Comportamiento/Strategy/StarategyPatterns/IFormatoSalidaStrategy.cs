using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarategyPatterns
{
    public interface IFormatoSalidaStrategy
    {
        void etquetaApertura(StringBuilder sb);
        void contenido(StringBuilder sb, string item);
        void etiquetaCierre(StringBuilder sb);
    }
    public enum FormatoSalida
    {
        formatoHtml,
        formatoNumerico
    }
}
