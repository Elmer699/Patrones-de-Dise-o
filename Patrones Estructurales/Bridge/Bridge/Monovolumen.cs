using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Monovolumen : Vehiculo
    {
        public bool PuertaCorrediza { get; set; }
        public Monovolumen(IMotor motor, bool PuertaCorrediza) : base(motor)
        {
            this.PuertaCorrediza = PuertaCorrediza;
        }
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Monovolumen " + (PuertaCorrediza ?" con" : " sin ") + "puerta corrediza");
        }
    }
}
