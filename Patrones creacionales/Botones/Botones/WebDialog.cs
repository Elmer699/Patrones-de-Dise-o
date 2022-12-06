using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones
{
    public class WebDialog : Dialog
    {
        public override IButton FactoryMethod()
        {
            return new HTML();
        }
    }
}
