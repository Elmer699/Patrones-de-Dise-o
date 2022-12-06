using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComponente
    {
        string Nombre { get; set; }

        void Add(IComponente componente);
        void Delete(IComponente component);
        bool buscarComponent();
    }
}
