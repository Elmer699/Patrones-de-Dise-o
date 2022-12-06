using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateFasesGoku
{
    public class Transformacion
    {
        Estado _estado;
        public Transformacion()
        {
            _estado = new UltraInstinto();
        }
        public void DefinirEstado(Estado estado)
        {
            this._estado = estado;
        }
        public void Transformar()
        {
            _estado.ControladordeEstado(this);
            Console.WriteLine(_estado.Descripcion());
        }
    }
}
