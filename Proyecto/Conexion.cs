using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class Conexion
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;//cadena de conexion

        public void InsercionDatosCliente(string identificacion, string nombre, string pApellido, string sApellido, string correo, string celular)
        {//metodo para insertar informacion a la base de datos
            string query = "insert into Clientes values(@IDENTIFICACION, @NOMBRE, @APELLIDO1, @APELLIDO2, @CORREOELECTRONICO, @NUMCELULAR)";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IDENTIFICACION", identificacion);
                sqlCommand.Parameters.AddWithValue("@NOMBRE", nombre);
                sqlCommand.Parameters.AddWithValue("@APELLIDO1", pApellido);
                sqlCommand.Parameters.AddWithValue("@APELLIDO2", sApellido);
                sqlCommand.Parameters.AddWithValue("@CORREOELECTRONICO", correo);
                sqlCommand.Parameters.AddWithValue("@NUMCELULAR", celular);
                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error al momento de agregar los datos****" + e);
                }
            }
        }

        public List<Cliente> listaClientes()//metodo para solicitar informacion de clientes a la base de datos
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string query = "select IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2, CORREOELECTRONICO, NUMCELULAR from CLIENTES";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string id = sqlDataReader.GetString(0);

                        string nombre = sqlDataReader.GetString(1);

                        string pApellido = sqlDataReader.GetString(2);

                        string sApellido = sqlDataReader.GetString(3);

                        string correo = sqlDataReader.GetString(4);

                        string celular = sqlDataReader.GetString(5);

                        listaClientes.Add(new Cliente(id, nombre, pApellido, sApellido, correo, celular));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ha ocurrido un error " + e);
                }
            }
            return listaClientes;
        }

        public void InsercionDatosFuncionario(string identificacion, string nombre, string pApellido, string sApellido)
        {//metodo para insertar informacion de funcionarios a la base de datos
            string query = "insert into FUNCIONARIOS values(@IDENTIFICACION, @NOMBRE, @APELLIDO1, @APELLIDO2)";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IDENTIFICACION", identificacion);
                sqlCommand.Parameters.AddWithValue("@NOMBRE", nombre);
                sqlCommand.Parameters.AddWithValue("@APELLIDO1", pApellido);
                sqlCommand.Parameters.AddWithValue("@APELLIDO2", sApellido);
                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error al momento de agregar los datos****" + e);
                }
            }
        }

        public List<Funcionario> listaFuncionario()//metodo para solicitar informacion de clientes a la base de datos
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            string query = "select IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2 from FUNCIONARIOS";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string id = sqlDataReader.GetString(0);

                        string nombre = sqlDataReader.GetString(1);

                        string pApellido = sqlDataReader.GetString(2);

                        string sApellido = sqlDataReader.GetString(3);

                        listaFuncionario.Add(new Funcionario(id, nombre, pApellido, sApellido));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error " + e);
                }
            }
            return listaFuncionario;
        }

        public void InsercionDatosCategoria(string codigo, string descripcion)//metodo para insertar informacion de categorias a la base de datos
        {
            string query = "insert into CATEGORIAS values(@CODCATEGORIA, @DESCRIPCION)";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CODCATEGORIA", codigo);
                sqlCommand.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (SqlException)
                {

                    MessageBox.Show("Los datos para categoria han sido guardados previamente");
                }
            }
        }

        public List<CatalogoCategorias> listaCategorias()//metodo para solicitar informacion sobre las categorias a la base de datos
        {
            string query = "select CODCATEGORIA, DESCRIPCION  from CATEGORIAS";

            List<CatalogoCategorias> listaCategorias = new List<CatalogoCategorias>();

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string codigo = sqlDataReader.GetString(0);
                        string descripcion = sqlDataReader.GetString(1);

                        listaCategorias.Add(new CatalogoCategorias(codigo, descripcion));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ha ocurrido un error " + e);
                }
            }
            return listaCategorias;
        }

        public void InsercionDatosHidrometros(string nis, string marca, string numSerie, CatalogoCategorias catalogo, Cliente cliente)
        {//metodo para insertar informacion sobre hidrometross a la base de datos
            string query = "insert into HIDROMETROS values(@NIS, @MARCA, @NUMSERIE, @CODCATEGORIA, @IDENTIFICACION)";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@NIS", Convert.ToInt32(nis));
                sqlCommand.Parameters.AddWithValue("@MARCA", marca);
                sqlCommand.Parameters.AddWithValue("@NUMSERIE", Convert.ToInt32(numSerie));
                sqlCommand.Parameters.AddWithValue("@CODCATEGORIA", catalogo.Codigo);
                sqlCommand.Parameters.AddWithValue("@IDENTIFICACION", cliente.Identificacion);
                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error al momento de agregar los datos****" + e);
                }
            }
        }

        public List<Hidrometro> listaHidrometros()//metodo para solicitar informacion sobre hidrometros a la base de datos
        {
            List<Hidrometro> listaHidrometros = new List<Hidrometro>();

            string query = "select HIDROMETROS.NIS, HIDROMETROS.MARCA, CATEGORIAS.DESCRIPCION, CLIENTES.NOMBRE, CLIENTES.APELLIDO1, CLIENTES.APELLIDO2" +
                " from HIDROMETROS" +
                " inner join CLIENTES on CLIENTES.IDENTIFICACION = HIDROMETROS.IDENTIFICACION" +
                " inner join CATEGORIAS on HIDROMETROS.CODCATEGORIA = CATEGORIAS.CODCATEGORIA";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                try
                {
                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        int nis = sqlDataReader.GetInt32(0);
                        string marca = sqlDataReader.GetString(1);
                        string descripcion = sqlDataReader.GetString(2);
                        string cliente = sqlDataReader.GetString(3);
                        string apellido1 = sqlDataReader.GetString(4);
                        string apellido2 = sqlDataReader.GetString(5);

                        listaHidrometros.Add(new Hidrometro(nis, marca, 0, descripcion, cliente + " " + apellido2 + " " + apellido2));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("ha ocurrido un error" + e);
                }
            }
            return listaHidrometros;
        }

        public List<HistorialConsumo> listaConsumo(int numero)//metodo para solicitar el historial de consumo basado en el NIS
        {
            List<HistorialConsumo> listaConsumo = new List<HistorialConsumo>();

            string query = "select NIS, MES, FECHALECTURA, LECTURA from HISTORIALCONSUMO where NIS = @numero";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@numero", numero);
                sqlConnection.Open();

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int nis = sqlDataReader.GetInt32(0);
                        int mes = sqlDataReader.GetInt32(1);
                        DateTime fecha = sqlDataReader.GetDateTime(2);
                        int lectura = sqlDataReader.GetInt32(3);
                        
                        listaConsumo.Add(new HistorialConsumo(nis, mes, fecha.ToString("yyyy-dd-MM"), lectura));
                    }
                    sqlConnection.Close();
                }
            }
            return listaConsumo;
        }

        public void InsercionLecturas(string nis, string mes, string fecha, int lectura)
        {//metodo para insertar lecturas de hidrometros a la base de datos
            string query = "insert into HISTORIALCONSUMO values(@NIS, @MES, @FECHALECTURA, @LECTURA)";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@NIS", nis);
                sqlCommand.Parameters.AddWithValue("@MES", mes);
                sqlCommand.Parameters.AddWithValue("@FECHALECTURA", fecha);
                sqlCommand.Parameters.AddWithValue("@LECTURA", lectura);
                sqlConnection.Open();

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Ha ocurrido un error al momento de agregar los datos****" + e);
                }
            }
        }

        #region//metodos para verificar si hay elementos en la tablas de clientes, categorias,funcionarios e hidrometros
        public int ContadorClientes()//verifica si hay elementos en la tabla de clientes para habilitar el menu de hidrometros
        {
            string query = "select count(*) from CLIENTES";
            int contador = 0;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    contador = (Int32)sqlCommand.ExecuteScalar();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ha ocurrido un error" + e);
                }
            }
            return contador;
        }

        public int ContadorCategorias()//verifica si hay elementos en la tabla de categorias para habilitar el menu de hidrometros
        {
            string query = "select count(*) from CATEGORIAS";
            int contador = 0;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    contador = (Int32)sqlCommand.ExecuteScalar();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Ha ocurrido un error" + e);
                }
            }
            return contador;
        }

        public int ContadorFuncionarios()//verifica si hay elementos en la tabla de funcionarios
        {
            string query = "select count(*) from Funcionarios";

            int contador = 0;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();

                    contador = (Int32)sqlCommand.ExecuteScalar();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error" + e);
                }
            }
            return contador;
        }

        public int ContadorHidrometros()//verifica si hay elementos en la tabla de hidrometros
        {
            string query = "select count(*) from HIDROMETROS";

            int contador = 0;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();

                    contador = (Int32)sqlCommand.ExecuteScalar();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error" + e);
                }
            }
            return contador;
        }
        #endregion
    }
}
