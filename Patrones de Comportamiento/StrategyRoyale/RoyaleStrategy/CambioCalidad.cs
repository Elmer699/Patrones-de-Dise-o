using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleStrategy
{
    internal class CambioCalidad
    {
        public StringBuilder builder = new StringBuilder();
        private ITipoCalidad calidad;
        public void SeleccionarCalidad(Calidad _calidad)
        {
            switch (_calidad)
            {
                case Calidad.Comun:
                    calidad = new CalidadComun();
                    break;
                case Calidad.Epica:
                    calidad = new CalidadEpica();
                    break;
                case Calidad.Especial:
                    calidad = new CalidadEspecial();
                    break;
                case Calidad.Legendaria:    
                    calidad = new CalidadLegendaria();
                    break;
                default:
                    break;
            }
        }
        public void setEstrategia(IEnumerable<string> datosAInsertar)
        {
            calidad.etquetaApertura(builder);
            foreach (var item in datosAInsertar)
            {
                calidad.contenido(builder, item);
            }
            calidad.etiquetaCierre(builder);
        }
        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
