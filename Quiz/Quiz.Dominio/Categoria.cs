
using System.Collections.Generic;
using TurboRango.Dominio;

namespace Quiz.Dominio
{
    public class Categoria : Entidade
    {

        public string Nome { get; set; }

        public string Descricao { get; set; }


        public ICollection<Pergunta> Pergunta { get; set; }
    }
}

