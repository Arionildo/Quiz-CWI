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
                new Categoria { Nome = "Ciência",               Descricao = "Dos elementos que nos compõe até a física que nos segura na terra." },
                new Categoria { Nome = "Comidas E Bebidas",     Descricao = "Desde os ingredientes à diversos pratos e bebidas existentes ao redor do mundo." },
                new Categoria { Nome = "Conhecimentos Gerais",  Descricao = "Mistura de todos os assuntos das mais diversas áreas." },
                new Categoria { Nome = "Esportes",              Descricao = "Todas as modalidades, do mais leve ao mais radical." },
                new Categoria { Nome = "Filme",                 Descricao = "Tudo sobre filmes, atores e, quem sabe, até diretores!" },
                new Categoria { Nome = "Geografia",             Descricao = "Lugares, climas, vegetações e tudo mais que a natureza tem a oferecer." },
                new Categoria { Nome = "Jogos",                 Descricao = "'Piece of cake' para os mais aficionados em jogos, seus personagens e suas histórias." },
                new Categoria { Nome = "Música",                Descricao = "Questões relacionadas à bandas, cantores e todos os estilos musicais." },
                new Categoria { Nome = "TV",                    Descricao = "Para aqueles quem não perdem uma novela, uma série ou até mesmo um programa de celebridades." }
            );

            context.Perguntas.AddOrUpdate(
                p => p.Questao,

            #region Ciência
                new Pergunta
                {
                    Questao = "Qual a cor do cavalo branco de Napoleão?",
                    Resposta = "Branco",
                    erradoA = "Não sei",
                    erradoB = "Vou perguntar pra minha mãe",
                    erradoC = "Minha mãe não sabe",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 1
                },
            #endregion
            
            #region Comidas E Bebidas
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 2
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 2
                },
            #endregion
            
            #region Conhecimentos Gerais
                new Pergunta
                {
                    Questao = "Qual a cor do cavalo branco de Napoleão?",
                    Resposta = "Branco",
                    erradoA = "Não sei",
                    erradoB = "Vou perguntar pra minha mãe",
                    erradoC = "Minha mãe não sabe",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 3
                },
            #endregion
            
            #region Esportes
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 4
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 4
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 4
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 4
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 4
                },
            #endregion
            
            #region Filme
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 5
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 5
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 5
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 5
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 5
                },
            #endregion
            
            #region Geografia
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 6
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 6
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 6
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 6
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 6
                },
            #endregion
            
            #region Jogos
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 7
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 7
                },
            #endregion
            
            #region Música
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 8
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 8
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 8
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 8
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 8
                },
            #endregion
            
            #region TV
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napoleão?",
                     Resposta = "Branco",
                     erradoA = "Não sei",
                     erradoB = "Vou perguntar pra minha mãe",
                     erradoC = "Minha mãe não sabe",
                     Categoria_Id = 9
                 },
                new Pergunta
                {
                    Questao = "Qual a cor predominante da bandeira de Trinidad e Tobago?",
                    Resposta = "Vermelha",
                    erradoA = "Marrom",
                    erradoB = "Azul claro",
                    erradoC = "Amarelo",
                    Categoria_Id = 9
                },
                new Pergunta
                {
                    Questao = "Qual o nome científico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 9
                },
                new Pergunta
                {
                    Questao = "Qual é o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independência ou Morte",
                    erradoB = "Pelo Brasil, façam-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 9
                },
                new Pergunta
                {
                    Questao = "O que é Bricabraque?",
                    Resposta = "Coleção de objetos de artesanato",
                    erradoA = "Coleção de armas",
                    erradoB = "Coleção de jogo de cartas",
                    erradoC = "Coleção de revistas em quadrinhos",
                    Categoria_Id = 9
                }
            #endregion

            );
        }
    }
}
