using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class AbrirPortada : ICommand
    {
        private Portada portada;

        public AbrirPortada()
        {
            this.portada = new Portada();
        }

        public void Execute()
        {
            portada.conectar();
            portada.abrir();
            portada.desconectar();
        }
    }
}
