using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FabricaDeLineas
    {
        private List<ILineaLigera> lineas;

        public FabricaDeLineas()
        {
            this.lineas = new List<ILineaLigera>();
        }

        public ILineaLigera getLine(string color)
        {
            foreach (ILineaLigera li in this.lineas)
            {
                if (li.getColor().Equals(color))
                {
                    Console.WriteLine("Linea de color [" + color + "] encontrada, la devolvemos");
                    return li;
                }
            }
            Console.WriteLine("Creando una línea de color [" + color + "]");

            ILineaLigera linea = new Linea(color);
            this.lineas.Add(linea);

            return linea;
        }
    }
}
