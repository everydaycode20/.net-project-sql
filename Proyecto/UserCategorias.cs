using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class UserCategorias : UserControl
    {
        Conexion conexion;

        public UserCategorias()
        {
            InitializeComponent();
        }

        private void comboCodigoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item1 = comboCodigoCategoria.SelectedIndex;
            List<string> dom = new List<string>();
            dom.Add("Domiciliar");
            List<string> emp = new List<string>();
            emp.Add("Empresarial");
            if (item1 == 0)
            {
                comboDescripcion.DataSource = dom;
            }
            else
            {
                comboDescripcion.DataSource = emp;
            }
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            try
            {
                string item1 = (string)comboCodigoCategoria.SelectedItem;
                string item2 = (string)comboDescripcion.SelectedItem;
                

                if (item1 == null || item2 == null)
                {
                    MessageBox.Show("Debe seleccionar una opcion valida");
                }
                else if (conexion.ContadorCategorias() == 2)
                {
                    MessageBox.Show("Los datos para categoria han sido guardados previamente");
                }
                else
                {
                    conexion.InsercionDatosCategoria(item1, item2); ;

                    MessageBox.Show("Datos guardados con exito");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
    }
}
