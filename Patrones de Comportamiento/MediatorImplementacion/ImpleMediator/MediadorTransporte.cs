using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpleMediator
{
    public class MediadorTransporte : IMediadorTransporte
    {
        private Emisor _emisor;
        private Receptor _receptor;
        private bool estado;
        public void EstadoEnvio(bool estado)
        {
            this.estado = estado;
        }

        public bool LlegoEnvio()
        {
            return estado;
        }

        public void RegistrarEnvio(Emisor emisor)
        {
            this._emisor = emisor;
        }

        public void RegistrarLlegada(Receptor receptor)
        {
            this._receptor = receptor;
        }
    }
}
