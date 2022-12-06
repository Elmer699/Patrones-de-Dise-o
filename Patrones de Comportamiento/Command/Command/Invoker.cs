using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        private ICommand orden;

        public Invoker(ICommand orden)
        {
            this.orden = orden;
        }

        public void run()
        {
            orden.Execute();
        }
    }
}
