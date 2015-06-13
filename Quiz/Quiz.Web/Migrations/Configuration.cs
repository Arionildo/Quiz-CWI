namespace Quiz.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Quiz.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Quiz.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Categorias.AddOrUpdate(
                p => p.Nome,
                new Categoria { Nome = "Ci�ncia",               Descricao = "Dos elementos que nos comp�e at� a f�sica que nos segura na terra." },
                new Categoria { Nome = "Comidas E Bebidas",     Descricao = "Desde os ingredientes � diversos pratos e bebidas existentes ao redor do mundo." },
                new Categoria { Nome = "Conhecimentos Gerais",  Descricao = "Mistura de todos os assuntos das mais diversas �reas." },
                new Categoria { Nome = "Esportes",              Descricao = "Todas as modalidades, do mais leve ao mais radical." },
                new Categoria { Nome = "Filme",                 Descricao = "Tudo sobre filmes, atores e, quem sabe, at� diretores!" },
                new Categoria { Nome = "Geografia",             Descricao = "Lugares, climas, vegeta��es e tudo mais que a natureza tem a oferecer." },
                new Categoria { Nome = "Jogos",                 Descricao = "'Piece of cake' para os mais aficionados em jogos, seus personagens e suas hist�rias." },
                new Categoria { Nome = "M�sica",                Descricao = "Quest�es relacionadas � bandas, cantores e todos os estilos musicais." },
                new Categoria { Nome = "TV",                    Descricao = "Para aqueles quem n�o perdem uma novela, uma s�rie ou at� mesmo um programa de celebridades." }
            );
        }
    }
}
