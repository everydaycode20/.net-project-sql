using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class CatalogoCategorias//clase catagolo de categorias
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public CatalogoCategorias(string codigo, string descripcion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }
    }
}
