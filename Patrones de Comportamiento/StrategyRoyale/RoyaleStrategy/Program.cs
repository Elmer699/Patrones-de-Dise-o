using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CambioCalidad calidad = new CambioCalidad();
            calidad.SeleccionarCalidad(Calidad.Legendaria);
            calidad.setEstrategia(new[] { "Megacaballero", "Dragon Infernal" });
            calidad.SeleccionarCalidad(Calidad.Especial);
            calidad.setEstrategia(new[] { "Minipekka", "Monta Puerco" });
            calidad.SeleccionarCalidad(Calidad.Epica);
            calidad.setEstrategia(new[] { "Pekka","Globo Bombastico"});
            calidad.SeleccionarCalidad(Calidad.Comun);
            calidad.setEstrategia(new[] { "Mago", "Monta Puerco" });

            Console.WriteLine(calidad.ToString());
        }
    }
}
