using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehiculo
    {
        private IMotor motor;

        public Vehiculo(IMotor motor)
        {
            this.motor = motor;
        }

        public void Acelarar(double combustible)
        {
            motor.InyectarCombustible(combustible);
            motor.ConsumirCombustible();
        }

        public void Frenar()
        {
            Console.WriteLine("El vehiculo esta frenando");
        }

        public abstract void MostrarCaracteristicas();
    }
}
