using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampObserver
{
    public interface ISujetoCamp
    {
        void Agregar(ICamp camp);
        void Quitar(ICamp camp);
        void Notificar();
    }
}
