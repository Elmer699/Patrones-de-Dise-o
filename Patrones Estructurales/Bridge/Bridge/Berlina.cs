using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Berlina : Vehiculo
    {
        public int CapacidadMaletero { get; set; }
        public Berlina(IMotor motor, int CapacidadMaletero) : base(motor)
        {
            this.CapacidadMaletero = CapacidadMaletero;
        }
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Berlina con una capacidad de " + CapacidadMaletero + " litros");
        }
    }
}
