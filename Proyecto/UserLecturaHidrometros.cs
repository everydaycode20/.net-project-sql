using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BibliotecaClases;

namespace GUI
{
    public partial class UserLecturaHidrometros : UserControl
    {
        Conexion conexion;

        public UserLecturaHidrometros()
        {
            InitializeComponent();
            
        }

        private void boxLectura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            try
            {
                string item1 = Convert.ToString(comboBoxNisLectura.SelectedItem);
                string item2 = (string)comboBoxMes.SelectedItem;

                if (item1 == null || item2 == null || string.IsNullOrWhiteSpace(boxLectura.Text))
                {
                    MessageBox.Show("Debe llenar todos los espacios");
                }
                else
                {
                    string fecha = calendario.SelectionRange.Start.ToString("yyyy-MM-dd");
                    string fechaMes = calendario.SelectionRange.Start.ToString("MM");
                    string mesSeleccionado = (string)comboBoxMes.SelectedItem;
                    int mesSeleccionadoInt = Convert.ToInt32(comboBoxMes.SelectedItem);
                    int mesAnterior = (mesSeleccionadoInt - 1);
                    int nis = Convert.ToInt32(comboBoxNisLectura.SelectedItem);
                    List<HistorialConsumo> listica = conexion.listaConsumo(nis);
                    int indiceMes = 0;

                    for (int i = 0; i < listica.Count; i++)
                    {
                        if (listica[i].Mes == mesAnterior)
                        {
                            indiceMes = i;
                        }
                    }

                    if (mesSeleccionado != fechaMes)
                    {
                        MessageBox.Show("El mes seleccionado debe coincidir con la fecha escogida en el calendario");
                    }
                    else if (mesAnterior == 0)
                    {
                        conexion.InsercionLecturas(item1, comboBoxMes.SelectedItem.ToString(), fecha, Convert.ToInt32(boxLectura.Text));
                        MessageBox.Show("Datos agregados con exito");
                        boxLectura.ResetText();
                    }
                    else if (listica[indiceMes].Lectura > Convert.ToInt32(boxLectura.Text))
                    {
                        MessageBox.Show("La lectura del mes seleccionado no debe ser menor a la lectura del mes anterior");
                    }
                    else
                    {
                        conexion.InsercionLecturas(item1, comboBoxMes.SelectedItem.ToString(), fecha, Convert.ToInt32(boxLectura.Text));
                        MessageBox.Show("Datos agregados con exito");
                        boxLectura.ResetText();
                    }
                    mostrarNis(2);
                    mostrarNis(1);
                    comboBoxMes.Items.Clear();
                    textLecturaAnterior.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar" + ex);
            }
        }

        public void mostrarNis(int n)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            if (n == 1)
            {
                for (int i = 0; i < conexion.listaHidrometros().Count; i++)
                {
                    comboBoxNisLectura.Items.Add(conexion.listaHidrometros()[i].Nis);
                }
            }
            else
            {
                for (int i = 0; i < conexion.listaHidrometros().Count; i++)
                {
                    comboBoxNisLectura.Items.Remove(conexion.listaHidrometros()[i].Nis);
                }
            }
        }

        private void comboBoxNisLectura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nisSeleccionado = (int)comboBoxNisLectura.SelectedItem;

            List<string> nuevaLista = new List<string>();
            List<HistorialConsumo> listica = conexion.listaConsumo(nisSeleccionado);
            List<string> mesesRegistrados = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            comboBoxMes.Items.Clear();

            for (int i = 0; i < listica.Count; i++)
            {
                for (int j = 0; j < mesesRegistrados.Count; j++)
                {
                    if (listica[i].Mes.ToString() == mesesRegistrados[j])
                    {
                        mesesRegistrados.RemoveAt(j);
                    }
                }
            }
            foreach (string item in mesesRegistrados)
            {
                nuevaLista.Add(string.Format("{0}{1}", 0, item));
            }
            for (int i = 0; i < nuevaLista.Count; i++)
            {
                if (nuevaLista[i] == "012")
                {
                    nuevaLista[i] = "12";
                }
                if (nuevaLista[i] == "011")
                {
                    nuevaLista[i] = "11";
                }
                if (nuevaLista[i] == "010")
                {
                    nuevaLista[i] = "10";
                }
            }
            for (int i = 0; i < nuevaLista.Count; i++)
            {
                comboBoxMes.Items.Add(nuevaLista[i]);
            }
        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            int mesAnterior = (Convert.ToInt32(comboBoxMes.SelectedItem)) - 1;
            int indiceLectura = 0;
            int nis = (Convert.ToInt32(comboBoxNisLectura.SelectedItem));
            List<HistorialConsumo> listica = conexion.listaConsumo(nis);

            if (listica.Count == 0)
            {
                textLecturaAnterior.Text = "0";
            }
            else
            {
                for (int i = 0; i < listica.Count; i++)
                {
                    if (listica[i].Mes == mesAnterior)
                    {
                        indiceLectura = i;
                    }
                    else
                    {
                        indiceLectura = 13;
                    }
                }
                if (indiceLectura == 13)
                {
                    MessageBox.Show("Debe seleccionar el mes anterior");
                    textLecturaAnterior.Text = Convert.ToString(0);
                }
                else
                {
                    textLecturaAnterior.Text = Convert.ToString(listica[indiceLectura].Lectura);
                }
            }
        }
    }
}
