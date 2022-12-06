using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Archivo
    {
        public Componente componente;
        public string extension { get; set; }
        public Archivo(string extension)
        {
            this.extension = extension;
        }
        public string editarContenido() 
        {
            return "";
        }
        public string borrarContenido()
        {
            return "";
        }
    }
}
