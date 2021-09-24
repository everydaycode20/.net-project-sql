using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;
using GUI;

namespace Proyecto_Eddy_Aguero_Carrillo
{
    public partial class UserClientes : UserControl
    {
        Conexion conexion;
        Cliente cliente = new Cliente("", "", "", "", "", "");
        public UserClientes()
        {
            InitializeComponent();
           
        }

        #region//eventos para el teclado ventana cliente
        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textNumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        #endregion

        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            try
            {
                string id = textId.Text;

                if (buscarId(id) == -1)
                {
                    if (string.IsNullOrWhiteSpace(textId.Text) || string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textPrimerApellido.Text) ||
                    string.IsNullOrWhiteSpace(textSegundoApellido.Text) || string.IsNullOrWhiteSpace(textCorreoElectronico.Text) ||
                        string.IsNullOrWhiteSpace(textNumeroCelular.Text))
                    {
                        MessageBox.Show("Debe llenar todos los espacios");
                    }
                    else
                    {
                        conexion.InsercionDatosCliente(textId.Text, textNombre.Text, textPrimerApellido.Text,
                            textSegundoApellido.Text, textCorreoElectronico.Text, textNumeroCelular.Text);

                        resetearEspacios(1);

                        MessageBox.Show("Datos guardados con exito");
                    }
                }
                else
                {
                    MessageBox.Show("Ese numero de identificacion ya existe, por favor ingrese uno distinto");
                    textId.ResetText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar" + ex);
            }
        }


        public int buscarId(string id)
        {
            List<Cliente> listaH = new List<Cliente>();
            listaH = conexion.listaClientes();

            for (int i = 0; i < listaH.Count; i++)
            {
                if (id == listaH[i].Identificacion)
                {
                    return 1;
                }
            }
            return -1;
        }
        public void resetearEspacios(int opcion)//metodo para restaurar las cajas de texto
        {
            if (opcion == 1)
            {
                textId.ResetText();
                textNombre.ResetText();
                textSegundoApellido.ResetText();
                textPrimerApellido.ResetText();
                textNumeroCelular.ResetText();
                textCorreoElectronico.ResetText();
            }
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            textId.BorderStyle = BorderStyle.FixedSingle;
        }

        private void textId_MouseClick(object sender, MouseEventArgs e)
        {
            textId.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
