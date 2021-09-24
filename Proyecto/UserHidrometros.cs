using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BibliotecaClases;

namespace GUI
{
    public partial class UserHidrometros : UserControl
    {
        Conexion conexion;
        public UserHidrometros()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
                gridClientesHidrometros.DataSource = conexion.listaClientes();
                gridClientesHidrometros.AutoGenerateColumns = false;
                DataGridViewReordenado();
                gridClientesHidrometros.DataSource = conexion.listaClientes();
            }
        }

        private void btnRegistrarHidrometro_Click(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            try
            {
                int c;
                string item1 = (string)comboBoxCategoria.SelectedItem;
                int numeroNis = Convert.ToInt32(textNIS.Text);

                if (string.IsNullOrWhiteSpace(textNIS.Text) || string.IsNullOrWhiteSpace(textMarca.Text) ||
                    string.IsNullOrWhiteSpace(textNumeroSerie.Text) ||
                    item1 == null)
                {
                    MessageBox.Show("Debe llenar todos los espacios");
                }
                else
                {
                    if (buscarNis(numeroNis) == -1)
                    {
                        if (Convert.ToString(comboBoxCategoria.SelectedItem) == "Domiciliar")
                        {
                            c = BusquedaIdCatalogo("Domiciliar");
                        }
                        else
                        {
                            c = BusquedaIdCatalogo("Empresarial");
                        }

                        string id = GetIdCliente();

                        int p = BusquedaId(id);

                        conexion.InsercionDatosHidrometros(textNIS.Text, textMarca.Text, textNumeroSerie.Text, conexion.listaCategorias()[c],
                            conexion.listaClientes()[p]);

                        MessageBox.Show("Datos guardados con exito");

                        textNIS.ResetText();
                        textMarca.ResetText();
                        textNumeroSerie.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Ese numero Nis ya esta registrado, por favor, digite un numero distinto");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar" + ex);
            }
        }

        public int buscarNis(int nis)
        {
            List<Hidrometro> listaH = new List<Hidrometro>();
            listaH = conexion.listaHidrometros();

            for (int i = 0; i < listaH.Count; i++)
            {
                if (nis == listaH[i].Nis)
                {
                    return 1;
                }
            }
            return -1;
        }

        private void textNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textNumeroSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public int BusquedaIdCatalogo(string x)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            for (int i = 0; i < conexion.listaCategorias().Count; i++)
            {
                if (conexion.listaCategorias()[i].Descripcion == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int BusquedaId(string x)
        {
            for (int i = 0; i < conexion.listaClientes().Count; i++)
            {
                if (conexion.listaClientes()[i].Identificacion == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public string GetIdCliente()//obtener la identificacion del cliente seleccionado en la tabla
        {
            string id = (string)gridClientesHidrometros.Rows[gridClientesHidrometros.CurrentRow.Index].Cells[2].Value;

            return id;
        }
        public void DataGridViewReordenado()
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                gridClientesHidrometros.Columns["Identificacion"].DisplayIndex = 0;
                gridClientesHidrometros.Columns["Nombre"].DisplayIndex = 1;
                gridClientesHidrometros.Columns["PrimerApellido"].DisplayIndex = 2;
                gridClientesHidrometros.Columns["SegundoApellido"].DisplayIndex = 3;
                gridClientesHidrometros.Columns["Correo"].DisplayIndex = 4;
                gridClientesHidrometros.Columns["Celular"].DisplayIndex = 5;

                gridClientesHidrometros.Columns[1].Width = 80;
                gridClientesHidrometros.Columns[3].Width = 80;
            }
        }

        public void mostrarCategorias(int n)
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                conexion = new Conexion();
            }
            if (n == 1)
            {
                for (int i = 0; i < conexion.listaCategorias().Count; i++)
                {
                    comboBoxCategoria.Items.Add(conexion.listaCategorias()[i].Descripcion);
                }
            }
            else
            {
                for (int i = 0; i < conexion.listaCategorias().Count; i++)
                {
                    comboBoxCategoria.Items.Remove(conexion.listaCategorias()[i].Descripcion);
                }
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            limpiar();
            foreach (DataGridViewRow item in gridClientesHidrometros.Rows)
            {
                if (item.Cells["Identificacion"].FormattedValue.ToString().StartsWith(textBusqueda.Text))
                {
                    item.Visible = true;
                }
            }

            if (string.IsNullOrWhiteSpace(textBusqueda.Text))
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gridClientesHidrometros.DataSource];
                currencyManager.SuspendBinding();

                for (int i = 0; i < gridClientesHidrometros.RowCount; i++)
                {
                    gridClientesHidrometros.Rows[i].Visible = true;
                }
                currencyManager.ResumeBinding();
            }
        }

        public DataGridView mos()
        {
            return gridClientesHidrometros;
        }

        public void limpiar()
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[gridClientesHidrometros.DataSource];
            currencyManager.SuspendBinding();

            for (int i = 0; i < gridClientesHidrometros.RowCount; i++)
            {
                gridClientesHidrometros.Rows[i].Visible = false;
            }
            currencyManager.ResumeBinding();

        }

        private void textBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridClientesHidrometros.DataSource = conexion.listaClientes();
        }
    }
}

