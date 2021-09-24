using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class Persona//clase principal de persona
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public Persona(string nombre, string primerApellido, string segundoApellido)
        {
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
        }
    }
}
