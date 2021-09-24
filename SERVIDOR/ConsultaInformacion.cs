using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BibliotecaClases;

namespace SERVIDOR
{
    public class ConsultaInformacion
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

        public int Nis { get; set; }
        public int Mes { get; set; }
        public string Fecha { get; set; }
        public int Lectura { get; set; }
        public string Categoria { get; set; }

        public ConsultaInformacion(int nis, int mes, string fecha, int lectura, string categoria)
        {//constructor para solicitar informacion del historial de consumo de los clientes
            this.Nis = nis;
            this.Mes = mes;
            this.Fecha = fecha;
            this.Lectura = lectura;
            this.Categoria = categoria;
        }

        public List<ConsultaInformacion> Consulta(int numero)
        {//metodo  para solicitar informacion sobre el historial de consumo a la base de datos basado en el numero NIS
            List<ConsultaInformacion> consulta = new List<ConsultaInformacion>();

            string query = "select HISTORIALCONSUMO.NIS, MES, FECHALECTURA, LECTURA, HIDROMETROS.CODCATEGORIA " +
                "from HISTORIALCONSUMO " +
                "inner join HIDROMETROS on HIDROMETROS.NIS = HISTORIALCONSUMO.NIS " +
                "where HISTORIALCONSUMO.NIS = @numero";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@numero", numero);
                sqlConnection.Open();

                try
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            int nis = sqlDataReader.GetInt32(0);
                            int mes = sqlDataReader.GetInt32(1);
                            DateTime fecha = sqlDataReader.GetDateTime(2);
                            int lectura = sqlDataReader.GetInt32(3);
                            string categoria = sqlDataReader.GetString(4);

                            consulta.Add(new ConsultaInformacion(nis, mes, fecha.ToString("YYYY-dd-MM"), lectura, categoria));
                        }
                        sqlConnection.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error " + e);
                }
            }
            return consulta;
        }

        public List<Hidrometro> listaHidrometros()//solicitar informacion de los hidrometros a la base de datos
        {
            List<Hidrometro> listaHidrometros = new List<Hidrometro>();

            string query = "select NIS, MARCA, NUMSERIE, CODCATEGORIA, IDENTIFICACION from HIDROMETROS";

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
                        int numSerie = sqlDataReader.GetInt32(2);
                        string categria = sqlDataReader.GetString(3);
                        string cliente = sqlDataReader.GetString(4);

                        listaHidrometros.Add(new Hidrometro(nis, marca, numSerie, categria, cliente));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error " + e);
                }
            }
            return listaHidrometros;
        }

        public int existeNis(int nis)//metodo que verifica si existen el nis en la lista de hidrometros, si no, retorna -1
        {
            List<Hidrometro> listaH = new List<Hidrometro>();

            listaH = listaHidrometros();

            for (int i = 0; i < listaH.Count; i++)
            {
                if (nis == listaH[i].Nis)
                {
                    return 1;
                }
            }
            return -1;
        }

        public string datosCliente(int nis, int mes)
        {//metodo que busca la informacion de lectura de hidrometros basado en el NIS y mes
            List<ConsultaInformacion> listica = new List<ConsultaInformacion>();//declaracion de lista de lecturas
            listica = Consulta(nis);//devuelve la lista con las lecturas de acuerdo al NIS
            string cadena = string.Empty;

            int estadoNis = 0;
            estadoNis = existeNis(nis);

            if (estadoNis == 1)//si existe el NIS en la lista continua
            {
                if (listica.Count == 0)
                {
                    string cadena1 = "0";
                    return cadena1;
                }

                int lecturaMesActual = 0;
                int lecturaMesAnterior = 0;
                double calculo = 0;
                string categoria = string.Empty;
                int costo = 0;
                int lecturaTotal = 0;
                double calculoIVA = 0;
                double total = 0;

                if (mes != 1)//si el mes consultado no es el primero
                {
                    for (int i = 0; i < listica.Count; i++)
                    {
                        if (mes == listica[i].Mes)
                        {
                            lecturaMesActual = listica[i].Lectura;
                            lecturaMesAnterior = listica[i - 1].Lectura;
                            if (listica[i].Categoria == "1")//si la categoria es 1 o 2, y el costo
                            {
                                categoria = "Domiciliar";
                                costo = 1000;
                            }
                            else
                            {
                                categoria = "Empresarial";
                                costo = 2000;
                            }
                        }
                    }
                    lecturaTotal = lecturaMesActual - lecturaMesAnterior;
                    calculo = (lecturaMesActual - lecturaMesAnterior) * costo;
                    calculoIVA = calculo * 0.13;
                    total = calculo + calculoIVA;//total calculado por la cantidad consumida
                    if (total == 0)//si el total es 0, o sea hay datos del mes en cuestion
                    {
                        string cadena1 = "1";
                        return cadena1;
                    }
                }
                else//si el mes es el primero
                {
                    if (listica[0].Categoria == "1")
                    {
                        categoria = "Domiciliar";
                        costo = 1000;
                    }
                    else
                    {
                        categoria = "Empresarial";
                        costo = 2000;
                    }
                    lecturaMesActual = listica[0].Lectura;
                    lecturaTotal = lecturaMesActual;
                    calculo = lecturaMesActual * costo;
                    calculoIVA = calculo * 0.13;
                    total = calculo + calculoIVA;//total calculado por la cantidad consumida
                    if (total == 0)//si el total es 0, o sea hay datos del mes en cuestion
                    {
                        string cadena1 = "1";
                        return cadena1;
                    }
                }
                //asigna a la variable un string con comas de cada uno de los datos requeridos, como el total a pagar por el consumo
                cadena = string.Format("{0},{1},{2},{3},{4},{5}", categoria, lecturaTotal, costo, calculo, calculoIVA, total);
            }
            else//si no existe el NIS ni el mes
            {
                string cadena1 = "2";
                return cadena1;
            }
            
            return cadena;
        }

    }
}
