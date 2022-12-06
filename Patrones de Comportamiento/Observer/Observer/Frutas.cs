using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Frutas
    {
        private double precioXKilo;
        private List<IRestaurante> restaurantes = new List<IRestaurante>();

        protected Frutas(double precioXKilo)
        {
            this.precioXKilo = precioXKilo;
        }
        public void Suscribe(IRestaurante restaurante)
        {
            this.restaurantes.Add(restaurante);
        }
        public void UnSuscribe(IRestaurante restaurante)
        {
            this.restaurantes.Remove(restaurante);
        }
        public void Notificar()
        {
            foreach (var item in restaurantes)
            {
                item.Update(this);
            }
        }
        public double PrecioXKilo
        {
            get { return precioXKilo; }
            set
            {
                if(precioXKilo != value)
                {
                    precioXKilo = 1;
                    this.precioXKilo = value;

                }
            }
        }
    }
}
