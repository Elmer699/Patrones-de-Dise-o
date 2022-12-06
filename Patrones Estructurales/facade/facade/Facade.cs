using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    public class Facade
    {
        AireAcondicionadoControlador aireacondicionado;
        WiFiControlador wificontrolador;
        LuzControlador luzControlador;


        public Facade(AireAcondicionadoControlador aire, WiFiControlador wifi, LuzControlador luz)
        {
            aireacondicionado = aire;
            wificontrolador = wifi;
            luzControlador = luz;
        }

        public string Operacion()
        {
            string resultado = "Se estan realizando las siguientes acciones:\n";

            resultado += this.aireacondicionado.Encender() + " \n";
            resultado += this.aireacondicionado.Apagar() + " \n";

            resultado += this.wificontrolador.Encender() + " \n";
            resultado += this.wificontrolador.Apagar() + " \n";

            resultado += this.luzControlador.Encender() + " \n";
            resultado += this.luzControlador.Apagar() + " \n";

            return resultado;
        }

        //$aireAcondicionado = new AireAcondicionadoControlador();
        //$wiFiControlador = new WiFiControlador();
        //$aireAcondicionado->Apagar();


    }
}
