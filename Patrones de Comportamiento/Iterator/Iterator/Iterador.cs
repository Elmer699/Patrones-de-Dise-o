using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface Iterador
    {
        Object primero();
        Object siguiente();
        bool hayMas();
        Object actual();

    }
}
