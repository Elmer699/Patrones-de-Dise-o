using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Pan
    {
        public abstract void MezclarIngredientes();
        public abstract void Hornear();
        public virtual void cortar()
        {
            Console.WriteLine($"Cortando el pan {GetType().Name}");
        }
        public void HacerPanTemplateMethod()
        {
            MezclarIngredientes();
            Hornear();
            cortar();   
        }
    }
}
