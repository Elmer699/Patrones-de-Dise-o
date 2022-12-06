using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjedrezStrategy
{
    public interface IMovimiento
    {
        string mover();
    }
    public enum tipoPieza
    {
        Peon,
        Caballo,
        Torre,
        Reina,
        Alfil,
        Rey
    }
}
