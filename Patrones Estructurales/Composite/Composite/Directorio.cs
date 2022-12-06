using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Directorio : IComponente
    {
        public string Nombre { get; set; }

        protected List<IComponente> componentes = new List<IComponente> { };

        public Directorio(string nombre, List<IComponente> componentes)
        {
            this.Nombre = nombre;
            this.componentes = componentes;
        }
        public void Add(IComponente componente)
        {
            this.componentes.Add(componente);
        }

        public bool buscarComponent()
        {
            throw new NotImplementedException();
        }

        public void Delete(IComponente componente)
        {
            this.componentes.Remove(componente);
        }
    }
}
