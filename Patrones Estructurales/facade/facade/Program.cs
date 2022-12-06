using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WiFiControlador wifi = new WiFiControlador();
            //AireAcondicionadoControlador aire = new AireAcondicionadoControlador();
            //LuzControlador luz = new LuzControlador();

            Facade facade = new Facade(AireAcondicionadoControlador aire, WiFiControlador wifi, LuzControlador luz);
            Console.WriteLine(facade.Operacion());


            //WiFiControlador wfControlador = new WiFiControlador();
            //AireAcondicionadoControlador aireAcondicionado = new AireAcondicionadoControlador();
            //LuzControlador luzControlador = new LuzControlador();
            //Console.WriteLine("Llegando a casa");
            //wfControlador.Encender();
            //aireAcondicionado.Encender();
            //luzControlador.Encender();
            //Console.WriteLine("Salir de casa");
            //wfControlador.Apagar();
            //aireAcondicionado.Apagar();
            //luzControlador.Apagar();

        }
    }
}
