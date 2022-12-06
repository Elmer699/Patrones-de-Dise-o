using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpleMediator
{
    public class Receptor
    {
        private string Nombre;
        private IMediadorTransporte _transporte;
        public Receptor(IMediadorTransporte transporte, string nombre)
        {
            _transporte = transporte;
            Nombre = nombre;    
        }
        public void Enviar()
        {
            if (_transporte.LlegoEnvio())
            {
                Console.WriteLine("El envio ya se hizo");
                _transporte.EstadoEnvio(true);
            }
            else
            {
                Console.WriteLine("Esperando el transporte para el envio");
            }
        }
        public void RegistroLLegada()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Registrando la llegada");
            Console.WriteLine("========================");
            Console.WriteLine("Nombre: " + Nombre);
        }
    }
}
