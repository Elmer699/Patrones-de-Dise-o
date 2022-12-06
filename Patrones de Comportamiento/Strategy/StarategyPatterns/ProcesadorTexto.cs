using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarategyPatterns
{
    internal class ProcesadorTexto
    {
        public StringBuilder sb = new StringBuilder();
        private IFormatoSalidaStrategy strategy;
        public void SeleccionaFormatoSalida(FormatoSalida formatoSalida)
        {
            switch (formatoSalida)
            {
                case FormatoSalida.formatoHtml:
                    strategy = new FormatoHtml();
                    break;
                case FormatoSalida.formatoNumerico:
                    strategy = new FormatoNumerico();
                    break;
                default:
                    break;
            }
        }
        public void setEstrategia(IEnumerable<string> datosAInsertar)
        {
            strategy.etquetaApertura(sb);
            foreach (var item in datosAInsertar)
            {
                strategy.contenido(sb, item);
            }
            strategy.etiquetaCierre(sb);
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
