using System.Collections.Generic;
using TurboRango.Dominio;

namespace Quiz.Dominio
{
  public class Pergunta : Entidade
    {

      public string Questao { set; get; }
      public string Resposta { set; get; }
      public string erradoA { set; get; }
      public string erradoB { set; get; }
      public string erradoC { set; get; }
      public virtual Categoria Categoria {set; get;  }

    

    }

}
