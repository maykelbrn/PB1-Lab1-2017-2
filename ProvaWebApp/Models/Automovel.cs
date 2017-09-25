using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaWebApp.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public bool Disponivel { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}