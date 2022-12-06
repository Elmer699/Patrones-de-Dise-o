using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones
{
    public class WindowsDialog : Dialog
    {
        public override IButton FactoryMethod()
        {
            return new Windows();
        }
    }
}
