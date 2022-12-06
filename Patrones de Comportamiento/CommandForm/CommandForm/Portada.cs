using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class Portada
    {
        public string conectar()
        {
            string texto = "Conectando al sistema de la portada...\n";
            try
            {
                texto += "Conexión al sistema de la portada establecida.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido establecer la conexión al sistema de la portada. ERROR:n " + e.ToString();
                //Console.WriteLine("No se ha podido establecer la conexión al sistema de iluminación. ERROR:n " + e.getMessage());
                return texto;
            }
        }
        public string desconectar()
        {
            string texto = "Desconectando del sistema de la portada...\n";
            try
            {
                texto += "Se ha desconectado del sistema de la portada.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido desconectar del sistema de la portada. ERROR:n" + e.ToString();
                return texto;
            }
        }
        public string abrir()
        {
            string texto = "Abriendo le portada...\n";
            try
            {
                texto += "Portada abierta.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido abrir la portada. ERROR:n" + e.ToString();
                return texto;
            }
        }
        public string cerrar()
        {
            string texto = "Cerrando la portada...\n";
            try
            {
                texto += "Portada cerrando.\n";
                return texto;
            }
            catch (Exception e)
            {
                texto += "No se ha podido cerrar la portada. ERROR:n" + e.ToString();
                return texto;
            }
        }
    }
}
