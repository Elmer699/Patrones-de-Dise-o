using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Restaurante : IRestaurante
    {
        private string nombre;
        private double precioLimite;

        public Restaurante(string nombre, double precioLimite)
        {
            this.nombre = nombre;
            this.precioLimite = precioLimite;
        }

        public void Update(Frutas frutas)
        {
            if ((frutas.PrecioXKilo)>precioLimite)
            {
                Console.WriteLine("Lo siento doña " + nombre + " El precio se excedio al precio limite");
            }
            else
            {
                Console.WriteLine("Se realizo la compra");
            }
        }
    }
}
