using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Portada
    {
		public bool conectar()
		{

			Console.WriteLine("Conectando al sistema de la portada...");

			try
			{

				Console.WriteLine("Conexión al sistema de la portada establecida.");

				return true;

			}
			catch (Exception e)
			{

				Console.WriteLine("No se ha podido establecer la conexión al sistema de la portada. ERROR:n" + e.ToString());

				return false;

			}

		}

		public bool desconectar()
		{

			Console.WriteLine("Desconectando del sistema de la portada...");

			try
			{

				Console.WriteLine("Se ha desconectado del sistema de la portada.");

				return true;

			}
			catch (Exception e)
			{

				Console.WriteLine("No se ha podido desconectar del sistema de la portada. ERROR:n" + e.ToString());

				return false;

			}

		}

		public bool abrir()
		{

			Console.WriteLine("Abriendo la portada...");

			try
			{

				Console.WriteLine("Portada abierta.");

				return true;

			}
			catch (Exception e)
			{

				Console.WriteLine("No se ha podido abrir la portada. ERROR:n" + e.ToString());

				return false;

			}

		}

		public bool cerrar()
		{

			Console.WriteLine("Cerrando la portada...");

			try
			{

				Console.WriteLine("Portada cerrada.");

				return true;

			}
			catch (Exception e)
			{

				Console.WriteLine("No se ha podido cerrar la portada. ERROR:n" + e.ToString());

				return false;

			}

		}
	}
}
