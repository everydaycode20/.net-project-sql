using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class Cliente:Persona//clase de cliente que hereda de persona
    {
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Identificacion { get; set; }
        public Cliente(string identificacion, string nombre, string primerApellido, string segundoApellido, string correo,
            string celular)
            : base(nombre, primerApellido, segundoApellido)//herencia
        {
            this.Identificacion = identificacion;
            this.Correo = correo;
            this.Celular = celular;
        }
    }
}
