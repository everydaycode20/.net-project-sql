using GUI;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Eddy_Aguero_Carrillo
{
    public partial class Form1 : Form
    {
        //GUI para la aplicacion base de datos
        Conexion conexion = new Conexion();//declaracion de objeto conexion donde estan los metodos para conectarse a la base de datos

        public Form1()
        {
            InitializeComponent();
            
            panel2.BringToFront();
            userClientes2.BringToFront();
            panelCliente.Visible = true;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = false;
            panelLectura.Visible = false;
            panelServicio.Visible = false;
            panelCategoriaVis.Visible = false;
            panelFuncionariosVis.Visible = false;
            panelHidrometroVis.Visible = false;

            int contadorClientes = conexion.ContadorClientes();//variables que obtienen el numero de clientes desde el metodo
            int contadorFuncionarios = conexion.ContadorFuncionarios();//variables que obtienen el numero de clientes desde el metodo
            int contadorCategorias = conexion.ContadorCategorias();//variables que obtienen el numero de clientes desde el metodo
            int contadorHidrometros = conexion.ContadorHidrometros();//variables que obtienen el numero de clientes desde el metodo

            if (contadorClientes > 0)//si existen datos, se muestran en el datagridview
            {
                mostrarClientes();
            }
            if (contadorFuncionarios > 0)//si existen datos, se muestran en el datagridview
            {
                mostrarFuncionarios();
            }
            if (contadorCategorias > 0)//si existen datos, se muestran en el datagridview
            {
                mostrarCategorias();
            }
            if (contadorHidrometros > 0)//si existen datos, se muestran en el datagridview
            {
                mostrarHidrometros();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de clientes
        {
            userClientes2.BringToFront();
            userLecturaHidrometros1.mostrarNis(2);
            userHidrometros3.mostrarCategorias(2);
            panelCliente.Visible = true;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = false;
            panelLectura.Visible = false;
            panelServicio.Visible = false;
        }

        private void bntFuncionarios_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de funcionarios
        {
            userFuncionarios1.BringToFront();
            userLecturaHidrometros1.mostrarNis(2);
            userHidrometros3.mostrarCategorias(2);
            panelCliente.Visible = false;
            panelFuncionarios.Visible = true;
            panelHidrometro.Visible = false;
            panelLectura.Visible = false;
            panelServicio.Visible = false;
        }

        private void btnHidrometros_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de hidrometros
        {
            userHidrometros3.BringToFront();
            userLecturaHidrometros1.mostrarNis(2);
            userHidrometros3.mostrarCategorias(1);
            int contadorClientes = conexion.ContadorClientes();
            int contadorCategorias = conexion.ContadorCategorias();
            
            if (contadorClientes == 0 && contadorCategorias == 0)//si no hay datos registrados en clientes y categorias
            {
                MessageBox.Show("Para usar esta opcion debe registrar al menos un cliente y una categoria");
                userHidrometros3.Enabled = false;
            }
            else if (contadorClientes == 0)//si no hay datos registrados en clientes
            {
                MessageBox.Show("Para usar esta opcion debe registrar al menos un cliente");
                userHidrometros3.Enabled = false;
            }
            else if (contadorCategorias == 0)//si no hay datos registrados en categorias
            {
                MessageBox.Show("Para usar esta opcion debe registrar al menos una categoria");
                userHidrometros3.Enabled = false;
            }
            else//si hay datos registrados en clientes y categorias
            {
                userHidrometros3.Enabled = true;
                mostrarHidrometros();
            }
            btnHidrometros.Image = ((System.Drawing.Image)(Resources.icono_hidrometro_V2));//cambia la imagen si se presiona el boton
            panelCliente.Visible = false;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = true;
            panelLectura.Visible = false;
            panelServicio.Visible = false;
        }

        private void btnServicios_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de categorias
        {
            userCategorias1.BringToFront();
            userLecturaHidrometros1.mostrarNis(2);
            userHidrometros3.mostrarCategorias(2);
            panelCliente.Visible = false;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = false;
            panelLectura.Visible = false;
            panelServicio.Visible = true;
        }

        private void btnListaHidrometros_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de lecutra de hidrometros
        {
            userLecturaHidrometros1.BringToFront();
            userLecturaHidrometros1.mostrarNis(1);
            userHidrometros3.mostrarCategorias(2);
            panelCliente.Visible = false;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = false;
            panelLectura.Visible = true;
            panelServicio.Visible = false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de registros
        {
            btnRegistro.BackColor = Color.FromArgb(0, 180, 216);
            btnRegistro.ForeColor = Color.White;
            btnVisualizacion.BackColor = Color.FromArgb(214, 240, 248);
            btnVisualizacion.ForeColor = Color.FromArgb(3, 4, 94);
            btnRegistro.Image = ((System.Drawing.Image)(Resources.icono_registro_BF));
            btnVisualizacion.Image = ((System.Drawing.Image)(Resources.icono_visualizar));
            panel2.BringToFront();
            userClientes2.BringToFront();
            panelCliente.Visible = true;
            panelFuncionarios.Visible = false;
            panelHidrometro.Visible = false;
            panelLectura.Visible = false;
            panelServicio.Visible = false;
        }

        private void btnVisualizacion_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de visualizaciones
        {
            btnRegistro.BackColor = Color.FromArgb(214, 240, 248);
            btnRegistro.ForeColor = Color.FromArgb(3, 4, 94);
            btnVisualizacion.Image = ((System.Drawing.Image)(Resources.icono_visualizar_B));
            btnRegistro.Image = ((System.Drawing.Image)(Resources.icono_registro_F));
            btnVisualizacion.BackColor = Color.FromArgb(0, 180, 216);
            btnVisualizacion.ForeColor = Color.White;
            panelVisualizacion.BringToFront();
            panel3.BringToFront();
            gridClientes.BringToFront();
            mostrarClientes();
            mostrarFuncionarios();
            mostrarCategorias();
            mostrarHidrometros();
            panelClientesVis.Visible = true;
            panelCategoriaVis.Visible = false;
            panelFuncionariosVis.Visible = false;
            panelHidrometroVis.Visible = false;
        }

        private void bntClientesVis_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de lista de clientes registrados
        {
            gridClientes.BringToFront();
            panelClientesVis.Visible = true;
            panelCategoriaVis.Visible = false;
            panelFuncionariosVis.Visible = false;
            panelHidrometroVis.Visible = false;
        }

        private void btnFuncionariosVis_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de funcionarios registrados
        {
            gridFuncionarios.BringToFront();
            panelClientesVis.Visible = false;
            panelCategoriaVis.Visible = false;
            panelFuncionariosVis.Visible = true;
            panelHidrometroVis.Visible = false;
        }

        private void bntCategoriasVis_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de lista de categorias registradas
        {
            gridCategorias.BringToFront();
            panelClientesVis.Visible = false;
            panelCategoriaVis.Visible = true;
            panelFuncionariosVis.Visible = false;
            panelHidrometroVis.Visible = false;
        }

        private void btnHidrometrosVis_Click(object sender, EventArgs e)//evento para el boton que visualiza el panel de lista de hidrometros
        {
            gridHidrometros.BringToFront();
            panelClientesVis.Visible = false;
            panelCategoriaVis.Visible = false;
            panelFuncionariosVis.Visible = false;
            panelHidrometroVis.Visible = true;
            mostrarHidrometros();
        }
        public void mostrarHidrometros()//metodo que obtiene los datos de hidrometros y los inserta en el datagridview
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                gridHidrometros.DataSource = conexion.listaHidrometros();
            }
        }
        public void mostrarClientes()//metodo que obtiene los datos de clientes y los inserta en el datagridview
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                gridClientes.DataSource = conexion.listaClientes();
            }
        }

        public void mostrarFuncionarios()//metodo que obtiene los datos de funcionarios y los inserta en el datagridview
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                gridFuncionarios.DataSource = conexion.listaFuncionario();
            }
        }

        public void mostrarCategorias()//metodo que obtiene los datos de categorias y los inserta en el datagridview
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                gridCategorias.DataSource = conexion.listaCategorias();
            }
        }

        private void btnHidrometros_MouseLeave(object sender, EventArgs e)//evento para el boton cuando el usuario aleja el mouse del icono
        {
            btnHidrometros.Image = ((System.Drawing.Image)(Resources.icono_hidrometro));
        }
    }
}
