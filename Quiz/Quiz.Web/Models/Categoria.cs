
using System.Collections.Generic;
using Quiz.Dominio;
using System.Web.Mvc;

namespace Quiz.Web
{
    public class Categoria : Entidade
    {

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public IEnumerable<SelectListItem> ListaCategorias { get; set; }

        public ICollection<Pergunta> Pergunta { get; set; }
    }
}

