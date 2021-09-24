using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE
{
    //GUI para la aplicacion Cliente
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private IPAddress ip = IPAddress.Parse("127.0.0.1");//declaracion de la variable de la IP
        private Thread t;
        public Form1()
        {
            InitializeComponent();

            inicio();

            btnConectar.Enabled = false;
            btnConectar.BackColor = Color.Gray;
        }

        private void inicio()
        {
            try
            {
                tcpClient = new TcpClient(ip.ToString(), 8900);//inicializa el cliente con respecto a la IP y Host
                t = new Thread(clienteProcesado);//inicializacion de un hilo y pasa el parametro delegado del metodo clienteProcesado
                t.IsBackground = true;//incida que el hilo estara en segundo plano
                t.Start(tcpClient);//inicia el hilo con el delegado agregando la variable de tcpCLiente
            }
            catch (SocketException e)
            {
                Console.WriteLine("error" + e);
            }
        }

        private void clienteProcesado(object obj)//metodo que pasa por parametro un objeto
        {
            TcpClient client = (TcpClient)obj;//declaracion de TcpCliente que pasandolo al objeto
            string datos = string.Empty;//declaracion de un string vacio
            StreamReader reader = null;//declaracion de variable que lee los datos del flujo
            StreamWriter writer = null;//declaracion que envia datos al flujo

            try//try catch en caso que suceda un error
            {
                reader = new StreamReader(client.GetStream());//obtiene el flujo de datos del cliente iniciado
                writer = new StreamWriter(client.GetStream());//obtiene el flujo de datos del cliente iniciado

                while (client.Connected)//mientras el cliente este conectado al servidor Tcp
                {
                    datos = reader.ReadLine();//lee los datos del flujo, enviados por el servidor
                    writer.WriteLine("");
                    if (datos != "conectado")//continua si los datos enviados por el servidor no coinciden con el string
                    {
                        if (datos == "error")//si los datos enviados por el servidor es "error" significa que no hay registros del mes que el cliente solicito
                        {
                            MessageBox.Show("No existen registros de ese mes");
                        }
                        else if (datos == "error1")//si los datos enviados por el servidor es "error1" significa que no hay registros del mes que el cliente solicito
                        {
                            MessageBox.Show("No existen registros de ese mes");
                        }
                        else if (datos == "error2")//si los datos enviados por el servidor es "error" significa que no hay registros del NIS que el cliente solicito
                        {
                            MessageBox.Show("Ingrese correctamente el NIS, el numero digitado no existe");
                        }
                        else
                        {//si existen los datos en la base, llama al metodo obtenerDatos y pasa el parametro de datos que el cliente capturo del flujo
                            obtenerDatos(datos);
                        }
                    }
                    
                }
                writer.Flush();//limpia el buffer y elimina los datos
            }
            catch (IOException)
            {
                tcpClient.Dispose();
                tcpClient.Close();
                t.Abort();
            }
        }

        public void obtenerDatos(string datos)//metodo que pasa por paremtro la cadena de strings separadas por comas
        {
            try
            {
                if (String.IsNullOrWhiteSpace(datos))//si no envia datos, se cierra el cliente
                {
                    tcpClient.Dispose();
                    tcpClient.Close();
                    t.Abort();
                }
                else
                {
                    string[] valores = datos.Split(new char[] { ',' });//convierte el string separado por coma en uun array

                    datoConsumo(valores[0]);//llama al metodo para insertar los datos del cliente al textbox
                    datoLectura(valores[1]);//llama al metodo para insertar los datos del cliente al textbox
                    datoCosto(valores[2]);//llama al metodo para insertar los datos del cliente al textbox
                    datoMonto(valores[3]);//llama al metodo para insertar los datos del cliente al textbox
                    datoIVA(valores[4]);//llama al metodo para insertar los datos del cliente al textbox
                    datoTotal(valores[5]);//llama al metodo para insertar los datos del cliente al textbox
                }
                
            }
            catch (Exception e)
            {
                tcpClient.Dispose();
                tcpClient.Close();
                t.Abort();
            }
        }

        private void textNis_KeyPress(object sender, KeyPressEventArgs e)//evento para evitar que el usuario digite letras en el textbox de NIS
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {//evento del boton para consultar la informacion basado en el NIS y el mes
            try
            {
                string mes = comboBoxMeses.Text;//obtiene los datos del mes
                string nis = textNis.Text;//obtiene los datos del NIs
                string cadena = string.Empty;//declara un string vacio
                if (tcpClient.Connected)//mientras el cliente este conectado al servidor Tcp
                {
                    if (String.IsNullOrWhiteSpace(nis))//si el usuario no ingreso ningun numero al espacio de NIS
                    {
                        MessageBox.Show("Debe ingresar un numero valido");
                    }
                    else
                    {
                        StreamWriter writer = new StreamWriter(tcpClient.GetStream());//declara una variable para enviar datos dependiendo del cliente que presione el boton
                        cadena = string.Format("{0},{1}", nis, mes);//con los datos obtenidos de los textbox, crea la cadena con el formato especificado
                        writer.WriteLine(cadena);//envia los datos al servidor para la consulta
                        writer.Flush();
                    }
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("error " + es);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());//declara una variable para enviar datos dependiendo del cliente cierre el Form
                writer.WriteLine("cerrado");//envia un mensaje al servidor de que el cliente cerro el Form
                writer.Flush();
                tcpClient.Dispose();
                tcpClient.Close();
                t.Abort();
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("terminado");
            }
        }
        #region//delegados para los espacios de texto
        private delegate void mostrarDatosConsumo(string mensaje);
        public void datoConsumo(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosConsumo(datoConsumo), new object[] { mensaje });
            }
            else
            {
                textConsumo.Text = mensaje;
            }
        }

        private delegate void mostrarDatosLectura(string mensaje);
        public void datoLectura(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosLectura(datoLectura), new object[] { mensaje });
            }
            else
            {
                textLectura.Text = mensaje;
            }
        }

        private delegate void mostrarDatosCosto(string mensaje);
        public void datoCosto(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosCosto(datoCosto), new object[] { mensaje });
            }
            else
            {
                textCosto.Text = mensaje;
            }
        }

        private delegate void mostrarDatosMonto(string mensaje);
        public void datoMonto(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosMonto(datoMonto), new object[] { mensaje });
            }
            else
            {
                textMonto.Text = mensaje;
            }
        }

        private delegate void mostrarDatosIVA(string mensaje);
        public void datoIVA(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosIVA(datoIVA), new object[] { mensaje });
            }
            else
            {
                textIva.Text = mensaje;
            }
        }

        private delegate void mostrarDatosTotal(string mensaje);
        public void datoTotal(string mensaje)
        {
            if (textConsumo.InvokeRequired)
            {
                Invoke(new mostrarDatosTotal(datoTotal), new object[] { mensaje });
            }
            else
            {
                texTotal.Text = mensaje;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)//evento para el boton de desconectar
        {
            try
            {
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());//declara una variable para enviar datos dependiendo del cliente que presiona el boton de desconectar
                writer.WriteLine("cerrado");//envia un mensaje al servidor de que el cliente cerro el Form
                writer.Flush();
                tcpClient.Dispose();
                tcpClient.Close();
                textNis.ResetText();//limpia el textbox de cualquier cadena de texto
                textConsumo.ResetText();//limpia el textbox de cualquier cadena de texto
                textLectura.ResetText();//limpia el textbox de cualquier cadena de texto
                textCosto.ResetText();//limpia el textbox de cualquier cadena de texto
                textMonto.ResetText();//limpia el textbox de cualquier cadena de texto
                textIva.ResetText();//limpia el textbox de cualquier cadena de texto
                texTotal.ResetText();//limpia el textbox de cualquier cadena de texto
                btnConectar.Enabled = true;//habilita el boton de conectar
                btnConectar.BackColor = Color.FromArgb(42, 157, 143);
                btnDesconectar.Enabled = false;
                btnDesconectar.BackColor = Color.Gray;
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("terminado");
            }
        }

        private void button9_Click(object sender, EventArgs e)//evento del boton para conectar
        {
            inicio();
            btnConectar.Enabled = false;
            btnConectar.BackColor = Color.Gray;
            btnDesconectar.BackColor = Color.FromArgb(230, 57, 70);
            btnDesconectar.Enabled = true;
        }

    }
}
