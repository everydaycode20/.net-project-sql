using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class HistorialConsumo//clase de historial de consumo
    {
        public int Nis { get; set; }
        public int Mes { get; set; }
        public string Fecha { get; set; }
        public int Lectura { get; set; }

        public HistorialConsumo(int nis, int mes, string fecha, int lectura)
        {
            this.Nis = nis;
            this.Mes = mes;
            this.Fecha = fecha;
            this.Lectura = lectura;
        }
    }
}
