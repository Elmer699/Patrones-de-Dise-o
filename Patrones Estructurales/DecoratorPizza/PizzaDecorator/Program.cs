using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            TipoPizza pizza = new TipoPizza();
            Console.WriteLine("Hawaiana sencilla: " + pizza.GetPrecio().ToString());
        
            ExtraQueso extraQueso = new ExtraQueso(pizza);
            ExtraQueso masextraQueso = new ExtraQueso(extraQueso);
            Console.WriteLine("Hawaiana simple con doble queso extra: " + masextraQueso.GetPrecio().ToString());

            Champiñon champiñon = new Champiñon(masextraQueso);
            Console.WriteLine("Hawaiana sencilla con doble extra de queso con champiñones: " + champiñon.GetPrecio().ToString());

            Jalapeño jalapeño = new Jalapeño(champiñon);
            Console.WriteLine("Hawaiana simple con doble queso extra con champiñones con jalapeño: " + jalapeño.GetPrecio().ToString());

            Console.ReadLine();
        }
    }
}
