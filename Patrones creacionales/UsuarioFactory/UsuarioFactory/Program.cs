using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioFactory
{
    internal class Program
    {
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Pais { get; set; }

            private Usuario(string nombre, string correo, string pais)
            {
                Nombre = nombre;
                Correo = correo;
                Pais = pais;
            }

            public class Factory
            {
                internal static Usuario PaisPorDefecto(string nombre, string correo)
                {
                    return new Usuario(nombre, correo, "Bolivia");
                }

                internal static Usuario CorreoPorDefecto(string nombre, string pais)
                {
                    return new Usuario(nombre, "ro@gmail.com", pais);
                }
            }
            
        }
        static void Main(string[] args)
        {
            //var Us = new Usuario("Pedro", "pedro@gmail.com");

            //var usuario = Usuario.PaisPorDefecto("Pedro", "pedro@gmail.com");
            //var correo = Usuario.CorreoPorDefecto("Pedro","Venezuela");

            var usuario = Usuario.Factory.PaisPorDefecto("Pedro", "pedro@gmail.com");
           

            Console.WriteLine($"Usuario: {usuario.Nombre}, Correo: {usuario.Correo}, Pais: {usuario.Pais}");
            //Console.WriteLine($"Usuario: {correo.Nombre}, Correo: {correo.Correo}, Pais: {correo.Pais}");
        }
    }
}
