using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpleMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediadorTransporte mediador = new MediadorTransporte();

            Emisor emisor = new Emisor(mediador, "Juan", "877253");
            Receptor receptor = new Receptor(mediador, "Ronal");
            mediador.RegistrarEnvio(emisor);
            mediador.RegistrarLlegada(receptor);
            emisor.RegistroDatos();
            receptor.Enviar();
            emisor.Enviar();
            receptor.Enviar();
            receptor.RegistroLLegada();
            
            Console.ReadKey();
        }
    }
}
