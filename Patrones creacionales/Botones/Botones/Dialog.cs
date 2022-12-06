using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones
{
    public abstract class Dialog
    {
        public abstract IButton FactoryMethod();

        public string SomecreateButton()
        {
            var button = FactoryMethod();
            var resultado = "" + button.createButton();
            return resultado;
        }

    }
}
