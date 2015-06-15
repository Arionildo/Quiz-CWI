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

            context.Perguntas.AddOrUpdate(
                p => p.Questao,

            #region Ci�ncia
                new Pergunta
                {
                    Questao = "Que tipo de rocha � a pedra m�rmore?",
                    Resposta = "Metam�rfica",
                    erradoA = "Magm�tica",
                    erradoB = "Sedimentar",
                    erradoC = "Rudimentar",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Como se chama a um lugar onde animais e plantas coabitam?",
                    Resposta = "Habitat",
                    erradoA = "Jardim bot�nico",
                    erradoB = "Casa",
                    erradoC = "Natureza",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "De que cor � a lingua da girafa?",
                    Resposta = "Azul",
                    erradoA = "Verde",
                    erradoB = "Amarela",
                    erradoC = "Vermelha",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Por quantas camadas � constituida a atmosfera?",
                    Resposta = "5 camadas",
                    erradoA = "2 camadas",
                    erradoB = "1 camada",
                    erradoC = "7 camadas",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Que nome se d� � Luz solar reflectida pela Lua?",
                    Resposta = "Luar",
                    erradoA = "Luz v�sivel",
                    erradoB = "Noite",
                    erradoC = "Eclipse lunar",
                    Categoria_Id = 1
                },
            #endregion
            
            #region Comidas E Bebidas
                 new Pergunta
                 {
                     Questao = "A Caipirinha � uma das bebidas brasileiras mais conhecidas nacionalmente e internacionalmente. A Caipirinha tem origem de qual estado brasileiro?",
                     Resposta = "Mato Grosso do Sul",
                     erradoA = "Esp�rito Santo",
                     erradoB = "S�o Paulo",
                     erradoC = "Pernambuco",
                     Categoria_Id = 2
                 },
                new Pergunta
                {
                    Questao = "O verdadeiro churrasco tradicional do Rio Grande do Sul � temperado, essencialmente, com:",
                    Resposta = "Sal grosso",
                    erradoA = "Vinho tinto",
                    erradoB = "Azeite de oliva",
                    erradoC = "Lim�o",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Diz a lenda que a feijoada � uma inven��o dos escravos, mas vale lembrar que n�o � um prato brasileiro e sim de origem Europeia. Em que pa�s foi inventada a feijoada?",
                    Resposta = "Portugal",
                    erradoA = "Alemanha",
                    erradoB = "It�lia",
                    erradoC = "Eslov�nia",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual a comida mais popular para mais da metade da popula��o mundial?",
                    Resposta = "Arroz",
                    erradoA = "Macarr�o",
                    erradoB = "Feij�o",
                    erradoC = "Frango",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual rio escoc�s fornece mais de 90% da �gua usada na fabrica��o de Whisky?",
                    Resposta = "Spey",
                    erradoA = "Weser",
                    erradoB = "Volga",
                    erradoC = "Dan�bio",
                    Categoria_Id = 2
                },
            #endregion
            
            #region Conhecimentos Gerais
                new Pergunta
                {
                    Questao = "Qual a cor do cavalo branco de Napole�o?",
                    Resposta = "Branco",
                    erradoA = "N�o sei",
                    erradoB = "Vou perguntar pra minha m�e",
                    erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 3
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 3
                },
            #endregion
            
            #region Esportes
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 4
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 4
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 4
                },
            #endregion
            
            #region Filme
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 5
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 5
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 5
                },
            #endregion
            
            #region Geografia
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 6
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 6
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 6
                },
            #endregion
            
            #region Jogos
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 7
                },
            #endregion
            
            #region M�sica
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 8
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 8
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 8
                },
            #endregion
            
            #region TV
                 new Pergunta
                 {
                     Questao = "Qual a cor do cavalo branco de Napole�o?",
                     Resposta = "Branco",
                     erradoA = "N�o sei",
                     erradoB = "Vou perguntar pra minha m�e",
                     erradoC = "Minha m�e n�o sabe",
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
                    Questao = "Qual o nome cient�fico do cacau?",
                    Resposta = "Theobroma cacau",
                    erradoA = "Malvaceae cacau",
                    erradoB = "Petrosetinum cacau",
                    erradoC = "Aechmea cacau",
                    Categoria_Id = 9
                },
                new Pergunta
                {
                    Questao = "Qual � o lema nacional do Brasil?",
                    Resposta = "Ordem e Progresso",
                    erradoA = "Independ�ncia ou Morte",
                    erradoB = "Pelo Brasil, fa�am-se grandes coisas",
                    erradoC = "Unidade, Trabalho, Progresso",
                    Categoria_Id = 9
                },
                new Pergunta
                {
                    Questao = "O que � Bricabraque?",
                    Resposta = "Cole��o de objetos de artesanato",
                    erradoA = "Cole��o de armas",
                    erradoB = "Cole��o de jogo de cartas",
                    erradoC = "Cole��o de revistas em quadrinhos",
                    Categoria_Id = 9
                }
            #endregion

            );
        }
    }
}
