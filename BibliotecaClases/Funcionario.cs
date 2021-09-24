using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class Funcionario:Persona//clase de funcionario que hereda de persona
    {
        public string Identificacion { get; set; }
        public Funcionario(string identificacion, string nombre, string primerApellido, string segundoApellido)
            : base(nombre, primerApellido, segundoApellido)//herencia
        {
            this.Identificacion = identificacion;
        }
    }
}
