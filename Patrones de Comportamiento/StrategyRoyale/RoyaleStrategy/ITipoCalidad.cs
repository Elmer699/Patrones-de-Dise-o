using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleStrategy
{
    public interface ITipoCalidad
    {
        void etquetaApertura(StringBuilder sb);
        void contenido(StringBuilder sb, string item);
        void etiquetaCierre(StringBuilder sb);
    }
    public enum Calidad
    {
        Comun,
        Especial,
        Epica,
        Legendaria
    }
}
