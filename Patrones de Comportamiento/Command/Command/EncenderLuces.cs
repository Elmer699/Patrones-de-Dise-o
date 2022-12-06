using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class EncenderLuces : ICommand
    {
        private Luces luces;

        public EncenderLuces()
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
