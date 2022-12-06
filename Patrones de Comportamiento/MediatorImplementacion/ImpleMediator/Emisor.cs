using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpleMediator
{
    public class Emisor
    {
        private string nombre;
        private string CI;
        private IMediadorTransporte _mediador;
        public Emisor(IMediadorTransporte mediador, string nombre, string CI)
        {
            this.nombre = nombre;
            this._mediador = mediador;
            this.CI = CI;
            this._mediador.EstadoEnvio(false);
        }
        public void RegistroDatos()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Se registro los datos");
            Console.WriteLine("========================");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine();
        }
        public void Enviar()
        {

            Console.WriteLine("Señor " + nombre + " El envio ya esta en camino");
            this._mediador.EstadoEnvio(true);
        }
    }
}
