using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ICommand command = null;
            if (instruccion.Text.Equals("encender") && objeto.Text.Equals("luces"))
            {
                command = new EncenderLuces();


            }
            else if (instruccion.Text.Equals("apagar") && objeto.Text.Equals("luces"))
            {

                command = new ApagarLuces();

            }
            else if (instruccion.Text.Equals("abrir") && objeto.Text.Equals("portada"))
            {

                command = new AbrirPortada();

            }
            else if (instruccion.Text.Equals("cerrar") && objeto.Text.Equals("portada"))
            {

                command = new CerrarPortada();

            }
            Invoker invoker = new Invoker(command);

            label1.Text = invoker.run();
        }

        private void Input1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (objeto.Text == "luces")
            {
                instruccion.Text = "";
                instruccion.Items.Clear();
                instruccion.Items.Add("encender");
                instruccion.Items.Add("apagar");
            }
            else if (objeto.Text == "portada")
            {
                instruccion.Text = "";
                instruccion.Items.Clear();
                instruccion.Items.Add("abrir");
                instruccion.Items.Add("cerrar");
            }
        }

        private void objeto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
