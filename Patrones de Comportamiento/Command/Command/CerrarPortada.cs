using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CerrarPortada : ICommand
    {
        private Portada portada;

        public CerrarPortada()
        {
            this.portada = new Portada();
        }

        public void Execute()
        {
            portada.conectar();
            portada.cerrar();
            portada.desconectar();
        }
    }
}
