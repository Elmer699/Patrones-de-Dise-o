using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class ApagarLuces : ICommand
    {
        private Luces luces;

        public ApagarLuces()
        {
            this.luces = new Luces();
        }

        public void Execute()
        {
            luces.conectar();
            luces.encender();
            luces.apagar();
        }
    }
}
