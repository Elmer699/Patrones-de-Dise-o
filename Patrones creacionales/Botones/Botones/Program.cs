using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones
{
    internal class Program
    {
        public class cliente
        {
            public void Main()
            {
                Console.WriteLine("App: Launched with the ConcreteCreator1.");
                devolver(new WebDialog());

                Console.WriteLine("");

                Console.WriteLine("App: Launched with the ConcreteCreator2.");
                devolver(new WindowsDialog());
            }
            private void devolver(Dialog dialog)
            {
                // ...
                Console.WriteLine("Client: I'm not aware of the creator's class," +
                    "but it still works.\n" + dialog.SomecreateButton());
            }
        }

        static void Main(string[] args)
        {
            new cliente().Main();
            //Console.WriteLine("App: Launched with the ConcreteCreator1.");
            //devolver(new WebDialog());

            //Console.WriteLine("");

            //Console.WriteLine("App: Launched with the ConcreteCreator2.");
            //devolver(new WindowsDialog());

        }
    }
}
