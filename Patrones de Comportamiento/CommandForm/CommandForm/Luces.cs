using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class Luces
    {
        public string conectar()
        {
            string texto = "";
            texto += "Conectando al sistema de iluminacion...\n";
            try
            {
                texto += "Conexión al sistema de iluminación establecida.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido establecer la conexión al sistema de iluminación. ERROR:n " + e.ToString();
                //Console.WriteLine("No se ha podido establecer la conexión al sistema de iluminación. ERROR:n " + e.getMessage());
                return texto;
            }
        }
        public string desconectar()
        {
            string texto = "Desconectando del sistema de iluminación...\n";
            try
            {
                texto += "Se ha desconectado del sistema de iluminación.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido desconectar del sistema de iluminación. ERROR:n" + e.ToString();
                return texto;
            }
        }
        public string encender()
        {
            string texto = "Encendiendo el sistema de iluminación...\n";
            try
            {
                texto += "Sistema de iluminación encendido.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido encender el sistema de iluminación. ERROR:n" + e.ToString();
                return texto;
            }
        }
        public string apagar()
        {
            string texto = "Apagando el sistema de iluminación...\n";
            try
            {
                texto += "Sistema de iluminación apagado.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido apagar el sistema de iluminación. ERROR:n" + e.ToString();
                return texto;
            }
        }
    }
}
