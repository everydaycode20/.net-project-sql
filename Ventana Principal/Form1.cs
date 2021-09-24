using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Principal
{
    public partial class Form1 : Form
    {
        //GUI para la ventana principal
        
        Proyecto_Eddy_Aguero_Carrillo.Form1 formDB;
        SERVIDOR.Form1 servidorForm;
        CLIENTE.Form1 clienteForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)//evento para el boton que inicia la base de datos
        {
            formDB = new Proyecto_Eddy_Aguero_Carrillo.Form1();
            formDB.Show();
        }

        private void button1_Click(object sender, EventArgs e)//evento para el boton que inicia el servidor
        {
            servidorForm = new SERVIDOR.Form1();
            servidorForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)//evento para el boton que inicia el cliente
        {
            clienteForm = new CLIENTE.Form1();

            clienteForm.Show();
        }
    }
}
