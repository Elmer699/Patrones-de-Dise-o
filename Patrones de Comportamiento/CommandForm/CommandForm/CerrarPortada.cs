using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class CerrarPortada : ICommand
    {
        private Portada portada;

        public CerrarPortada()
        {
            this.portada = new Portada();
        }

        public string execute()
        {
            string cad = "";
            cad += portada.conectar();
            cad += portada.cerrar();
            cad += portada.desconectar();
            return cad;
        }
    }
}
