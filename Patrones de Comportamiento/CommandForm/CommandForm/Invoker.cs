using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForm
{
    public class Invoker
    {
        private ICommand orden;
        public Invoker(ICommand ordens)
        {
            this.orden = ordens;
        }
        public string run()
        {
            return orden.execute().ToString();
        }
    }
}
