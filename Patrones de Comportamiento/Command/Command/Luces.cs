using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Luces
    {
        public bool conectar()
        {
            Console.WriteLine("Conectando al sistema de iluminación...");
            try
            {

                Console.WriteLine("Conexión al sistema de iluminación establecida.");

                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine("No se ha podido establecer la conexión al sistema de iluminación. ERROR:n" + e.ToString());

                return false;

            }

        }
        public bool desconectar()
        {

            Console.WriteLine("Desconectando del sistema de iluminación...");

            try
            {

                Console.WriteLine("Se ha desconectado del sistema de iluminación.");

                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine("No se ha podido desconectar del sistema de iluminación. ERROR:n" + e.ToString());

                return false;

            }
        }
        public bool encender()
        {

            Console.WriteLine("Encendiendo el sistema de iluminación...");

            try
            {

                Console.WriteLine("Sistema de iluminación encendido.");

                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine("No se ha podido encender el sistema de iluminación. ERROR:n" + e.ToString());

                return false;

            }

        }
        public bool apagar()
        {

            Console.WriteLine("Apagando el sistema de iluminación...");

            try
            {

                Console.WriteLine("Sistema de iluminación apagado.");

                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine("No se ha podido apagar el sistema de iluminación. ERROR:n" + e.ToString());

                return false;

            }

        }
    }
}
