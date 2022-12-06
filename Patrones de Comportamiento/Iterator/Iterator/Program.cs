using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            
                AgregadoConcreto agregado = new AgregadoConcreto();

                Iterador iterador = agregado.getIterador();

                String obj = (String)iterador.primero();
                Console.WriteLine(obj);
                iterador.siguiente();
                iterador.siguiente();

                Console.WriteLine((String)iterador.actual() + "\n");

                iterador.primero();

                while (iterador.hayMas() == true)
                {
                    Console.WriteLine(iterador.siguiente());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(System.Environment.StackTrace);
            }
        }
    }
}
