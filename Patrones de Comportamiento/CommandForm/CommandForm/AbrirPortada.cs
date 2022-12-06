using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class AbrirPortada : ICommand
    {
        private Portada portada;

        public AbrirPortada()
        {
            this.portada = new Portada();
        }

        public string execute()
        {
            string cadena = "";
            cadena += portada.conectar();
            cadena += portada.abrir();
            cadena += portada.desconectar();
            return cadena;
        }
    }
}
