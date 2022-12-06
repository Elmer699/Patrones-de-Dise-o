using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpleMediator
{
    public interface IMediadorTransporte
    {
        void RegistrarEnvio(Emisor emisor);
        void RegistrarLlegada(Receptor receptor);
        void EstadoEnvio(bool estado);
        bool LlegoEnvio();

    }
}
