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

namespace SERVIDOR
{
    //GUI para la aplicacion servidor
    public partial class Form1 : Form
    {
        private TcpListener tcpListener;
        private IPAddress ip = IPAddress.Parse("127.0.0.1");//declaracion de la variable de la IP
        List<TcpClient> clientList = new List<TcpClient>();//lista para guardar los clientes que se conectan al servidor
        public int contador = 0;
        private Thread t;

        ConsultaInformacion consultaInformacion = new ConsultaInformacion(0,0,"",0,"");
        public Form1()
        {
            InitializeComponent();

            t = new Thread(empezarServidor);//inicializacion de un hilo y pasa el parametro delegado del metodo empezarServidor
            t.IsBackground = true;//incida que el hilo estara en segundo plano
            t.Start();// inicia el hilo
        }

        private void empezarServidor()//metodo que inicializa el servidor y espera por clientes conectados
        {
            tcpListener = new TcpListener(ip, 8900);//inicializacion del servidor para conexiones entrantes
            tcpListener.Start();//empieza la la escucha de conexiones
            MostrarMensajeCaja(" esperando conexiones");//muestra el mensaje en la caja de texto

            while (true)//mientras haya clientes conectados
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();//acepta nuevas peticiones de clientes
                    contador++;
                    MostrarMensajeCaja(" usuario aceptado");

                    Thread t = new Thread(clientePeticion);//declara el hilo con el metodo delegado de clientePeticion
                    t.IsBackground = true;
                    t.Start(tcpClient);//pasa el parametro de tcpClient aceptado por el servidor
                }
                catch (SocketException)
                {
                    MostrarMensajeCaja(" usuario desconectado");
                }
                catch(InvalidOperationException)
                {
                    MostrarMensajeCaja(" desconectado");
                }
            }
        }

        private void clientePeticion(object obj)//metodo que pasa por parametro un objeto de cliente
        {
            TcpClient tcpClient = (TcpClient)obj;//declaracion de TcpCliente que pasandolo al objeto
            clientList.Add(tcpClient);//agrega a la lista el cliente conectado
            clientesConectados(Convert.ToString(clientList.Count));//metodo que muestra los clientes conectados en la GUI
            string datosCadena = string.Empty;//declaracion de string vacio
            try
            {
                StreamReader reader = new StreamReader(tcpClient.GetStream());//declaracion de variable que lee los datos que ha enviado el cliente
                StreamWriter writer = new StreamWriter(tcpClient.GetStream());//declaracion de variable que envia datos al cliente

                string message = string.Empty;//declaracion de string vacio

                while (tcpClient.Connected)//mientras el cliente este conectado
                {
                    message = reader.ReadLine();//lee los datos enviados y los asigna a la variable message

                    if (message == "cerrado")//si el mensaje equivale a cerrado, cierra el cliente
                    {
                        tcpClient.Close();
                        tcpClient.Dispose();
                        MostrarMensajeCaja(" Cliente desconectado");
                        clientList.Remove(tcpClient);//si el cliente se desconecta se elimina en la lista de clientes conectados
                        clientesConectados(Convert.ToString(clientList.Count));
                        break;
                    }
                    else if (message != "conectado")//si message no equivale a "conectado"
                    {
                        MostrarMensajeCaja(" consulta recibida");
                        datosCadena = Datos(message);//llama al metodo Datos y pasa el por parametro la variable message y lo asigna a datosCadena
                        if (datosCadena == "0")//si el mensaje obtenido por el metodo Datos equivale a 0
                        {
                            writer.WriteLine("error");//envia un mensaje al cliente de que existe un error debido a que el servidor no encontro los datos
                            MostrarMensajeCaja(" error en consulta ***");
                        }
                        else if (datosCadena == "1")//si el mensaje obtenido por el metodo Datos equivale a 1
                        {
                            writer.WriteLine("error1");//envia un mensaje al cliente de que existe un error debido a que el servidor no encontro los datos
                            MostrarMensajeCaja(" error en consulta ***");
                        }
                        else if (datosCadena == "2")//si el mensaje obtenido por el metodo Datos equivale a 2
                        {
                            writer.WriteLine("error2");
                            MostrarMensajeCaja(" error en consulta ***");//envia un mensaje al cliente de que existe un error debido a que el servidor no encontro los datos
                        }
                        else//si existen los datos
                        {
                            MostrarMensajeCaja(" informacion enviada");//escribe en la caja de texto
                            writer.WriteLine(datosCadena);//envia al cliente los datos obtenidos de la base de datos 
                        }
                    }
                    writer.Flush();//limpia el buffer y elimina los datos
                }
            }
            catch (Exception t)
            {
                tcpClient.Close();
                tcpListener.Stop();
                Console.WriteLine("desconectado" + t);
            }
        }

        public string Datos(string mensaje)//metodo que obtiene los datos pasando el parametro del string que envio el cliente
        {
            string cadena = string.Empty;
            try
            {
                string[] valores = mensaje.Split(new char[] { ',' });//convierte el string que paso por parametro separado por comas y lo convierte en array

                cadena = consultaInformacion.datosCliente(Convert.ToInt32(valores[0]), Convert.ToInt32(valores[1]));//asigna a la cadena el metodo que pide a la base de datos conforme al mensaje enviado por los clientes
            }
            catch (NullReferenceException er)
            {
                MessageBox.Show("error" + er);
            }
            return cadena;
        }

        #region//delegados para mostrar los mensajes
        private delegate void MostrarMensaje(string mensaje);
        public void MostrarMensajeCaja(string mensaje)
        {
            try
            {
                if (textEstatus.InvokeRequired)
                {
                    Invoke(new MostrarMensaje(MostrarMensajeCaja), new object[] { mensaje });
                }
                else
                {
                    textEstatus.AppendText(DateTime.Now.ToString("h:mm:ss") + mensaje);
                    textEstatus.AppendText(Environment.NewLine);
                }
            }
            catch (Exception)
            {
                tcpListener.Stop();
            }
        }

        private delegate void mostrarClientesConectados(string mensaje);
        public void clientesConectados(string mensaje)
        {
            if (textEstatus.InvokeRequired)
            {
                Invoke(new mostrarClientesConectados(clientesConectados), new object[] { mensaje });
            }
            else
            {
                labelClientesConectados.Text = mensaje;
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (TcpClient item in clientList)
                {
                    item.Close();//si el servidor se cierra, todos los clientes tambien
                }

                clientList.Clear();
                tcpListener.Stop();
                t.Abort();
            }
            catch (Exception)
            {
                MostrarMensajeCaja("error cerrando");
            }
        }
    }
}
