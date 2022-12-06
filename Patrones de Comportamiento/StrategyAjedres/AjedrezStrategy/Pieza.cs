using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezStrategy
{
    public class Pieza
    {
        public string color { get; set; }
        public string posicion { get; set; }
        private IMovimiento movimiento;
        public tipoPieza _tipoPieza { get; set; }
        public void TipoPieza(tipoPieza tipoPieza)
        {
            _tipoPieza = tipoPieza;
        }
        public void SelecionarPieza(tipoPieza tipo)
        {
            switch (tipo)
            {
                case tipoPieza.Alfil:
                    movimiento = new MovimientoAlfil();
                    break;
                case tipoPieza.Caballo:
                    movimiento = new MovimientoCaballo();
                    break;
                case tipoPieza.Peon:
                    movimiento = new MovimientoPeon();
                    break;
                case tipoPieza.Torre:
                    movimiento = new MovimientoTorre();
                    break;
                case tipoPieza.Reina:
                    movimiento = new MovimientoReina();
                    break;
                case tipoPieza.Rey:
                    movimiento = new MovimientoRey();
                    break;
                default:
                    break;
            }
        }
    }
}
