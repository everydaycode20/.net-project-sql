using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserFuncionarios : UserControl
    {
        Conexion conexion;
        public UserFuncionarios()
        {
            InitializeComponent();
        }

        private void textIdFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textNombreFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textPrimerApellidoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textSegundoApellidoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnRegistrarFuncionario_Click(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            try
            {
                if (string.IsNullOrWhiteSpace(textIdFuncionario.Text) || string.IsNullOrWhiteSpace(textNombreFuncionario.Text) ||
                   string.IsNullOrWhiteSpace(textPrimerApellidoFuncionario.Text) || 
                   string.IsNullOrWhiteSpace(textSegundoApellidoFuncionario.Text))
                {
                    MessageBox.Show("Debe llenar todos los espacios");
                }
                else
                {
                    conexion.InsercionDatosFuncionario(textIdFuncionario.Text, textNombreFuncionario.Text,
                        textPrimerApellidoFuncionario.Text, textSegundoApellidoFuncionario.Text);

                    resetearEspacios(2);

                    MessageBox.Show("Datos guardados con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar" + ex);
            }
        }
        public void resetearEspacios(int opcion)//metodo para restaurar las cajas de texto
        {
            if (opcion == 2)
            {
                textIdFuncionario.ResetText();
                textNombreFuncionario.ResetText();
                textPrimerApellidoFuncionario.ResetText();
                textSegundoApellidoFuncionario.ResetText();
            }
        }
    }
}
