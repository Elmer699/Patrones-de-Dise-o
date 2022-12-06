using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class EncenderLuces : ICommand
    {
        private Luces luces;

        public EncenderLuces()
        {
            this.luces = new Luces();
        }

        public string execute()
        {
            string cadena = "";
            cadena += luces.conectar();
            cadena += luces.encender();
            cadena += luces.desconectar();
            return cadena;
        }
    }
}
