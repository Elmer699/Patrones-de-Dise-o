using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class ApagarLuces : ICommand
    {
        private Luces luces;

        public ApagarLuces()
        {
            this.luces = new Luces();
        }

        public string execute()
        {
            string cadena = "";
            cadena += luces.conectar();
            cadena += luces.apagar();
            cadena += luces.desconectar();
            return cadena;
        }
    }
}
