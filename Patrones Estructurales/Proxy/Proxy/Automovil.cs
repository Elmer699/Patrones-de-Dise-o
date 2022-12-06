using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Automovil : IAutomovil
    {
        public string Conductor { get; set; }
        public bool Permiso { get; set; }
        public int Edad { get; set; }

        public Automovil(string conductor , bool permiso, int edad)
        {
            Conductor = conductor;
            Permiso = permiso;
            Edad = edad;    
        }
        public string conducir()
        {
            return "EL Conductor: " + Conductor + " Tiene permiso: " + Permiso + " Tiene: " + Edad + " años";
        }
    }
}
