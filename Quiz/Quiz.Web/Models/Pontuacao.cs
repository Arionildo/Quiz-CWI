using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Web.Models
{
    public class Pontuacao : Entidade
    {
        public string Usuario { get; set; }
        public Categoria Categoria { get; set; }
        public string NomeCategoria { get; set; }
        public int Pontos { get; set; }
        public DateTime Data { get; set; }
    }
}