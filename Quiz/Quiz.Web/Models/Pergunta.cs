using System.Collections.Generic;

namespace Quiz.Web
{
  public class Pergunta : Entidade
    {

      public string Questao { set; get; }
      public string Resposta { set; get; }
      public string erradoA { set; get; }
      public string erradoB { set; get; }
      public string erradoC { set; get; }
      public string NomeCategoria { get; set; }
      public int Categoria_Id { get; set; }
      public int dificuldade { set; get; }

    }

}
