using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyAutomovil : IAutomovil
    {
        Automovil automovil;

        private string Conductor;
        private bool Permiso;
        private int Edad;

        public ProxyAutomovil(string condutor, bool permiso, int edad)
        {
            Conductor = condutor; 
            Permiso = permiso;
            Edad = edad;
        }
        public string conducir()
        {
            string resultado = string.Empty;
            if (Edad > 18)
            {
                if (Permiso == true)
                {
                    automovil = new Automovil(Conductor, Permiso, Edad);
                    resultado = automovil.conducir();
                }
                else
                    resultado = "Puede conducir pero cuidao" + " Edad:" + Edad;
            }
            else
                resultado = "No puede conducir";
            return resultado;
        }
    }
}
