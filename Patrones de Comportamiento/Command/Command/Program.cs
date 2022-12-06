using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommand command = null;
			string instruccion = "";
			string objeto = "";

            Console.WriteLine("Que tipo de instruccion desea realizar");
			instruccion = Console.ReadLine();
            Console.WriteLine("Que proceso desea realizar ");
			objeto = Console.ReadLine();

			if (instruccion.Equals("encender") && objeto.Equals("luces"))
			{

				command = new EncenderLuces();

			}
			else if (instruccion.Equals("apagar") && objeto.Equals("luces"))
			{

				command = new ApagarLuces();

			}
			else if (instruccion.Equals("abrir") && objeto.Equals("portada"))
			{

				command = new AbrirPortada();

			}
			else if (instruccion.Equals("cerrar") && objeto.Equals("portada"))
			{

				command = new CerrarPortada();

			}



			Invoker invoker = new Invoker(command);

			invoker.run();
		}
    }
}
