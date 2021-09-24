using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaClases
{
    public class Hidrometro//clase de hidrometro
    {
        public int Nis { get; set; }
        public string Marca { get; set; }
        public int NumeroSerie { get; set; }
        public string Categoria { get; set; }
        public string Cliente { get; set; }

        public Hidrometro(int nis, string marca, int numeroSerie, string categoria, string cliente)
        {
            this.Nis = nis;
            this.Marca = marca;
            this.NumeroSerie = numeroSerie;
            this.Categoria = categoria;
            this.Cliente = cliente;
        }
    }
}
