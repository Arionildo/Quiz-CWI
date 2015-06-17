namespace Quiz.Web.Migrations
{
    using Quiz.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Quiz.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Quiz.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Categorias.AddOrUpdate(
                p => p.Nome,
                new Categoria { Nome = "Ci�ncia", Descricao = "Dos elementos que nos comp�e at� a f�sica que nos segura na terra." },
                new Categoria { Nome = "Comidas E Bebidas", Descricao = "Desde os ingredientes � diversos pratos e bebidas existentes ao redor do mundo." },
                new Categoria { Nome = "Conhecimentos Gerais", Descricao = "Mistura de todos os assuntos das mais diversas �reas." },
                new Categoria { Nome = "Esportes", Descricao = "Todas as modalidades, do mais leve ao mais radical." },
                new Categoria { Nome = "Filme", Descricao = "Tudo sobre filmes, atores e, quem sabe, at� diretores!" },
                new Categoria { Nome = "Geografia", Descricao = "Lugares, climas, vegeta��es e tudo mais que a natureza tem a oferecer." },
                new Categoria { Nome = "Jogos", Descricao = "'Piece of cake' para os mais aficionados em jogos, seus personagens e suas hist�rias." },
                new Categoria { Nome = "M�sica", Descricao = "Quest�es relacionadas � bandas, cantores e todos os estilos musicais." },
                new Categoria { Nome = "TV", Descricao = "Para aqueles quem n�o perdem uma novela, uma s�rie ou at� mesmo um programa de celebridades." }
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
                    Questao = "Como se chama um lugar onde animais e plantas coabitam?",
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
                    Questao = "A lua n�o produz luz mas, mesmo assim, brilha � noite. Porqu�?",
                    Resposta = "Porque reflete a luz do sol",
                    erradoA = "Pois gira a uma velocidade alt�ssima",
                    erradoB = "Pois possui v�rias crateras",
                    erradoC = "Porque � coberta por uma fina camada de gelo",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual o nome do processo natural que transforma o vapor em �gua?",
                    Resposta = "Liquefa��o",
                    erradoA = "Fus�o",
                    erradoB = "Calefa��o",
                    erradoC = "Solidifica��o",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual g�s est� presente em maior quantidade na atmosfera terrestre?",
                    Resposta = "Nitrog�nio",
                    erradoA = "Gas carb�nico",
                    erradoB = "Oxig�nio",
                    erradoC = "Hidrog�nio",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual a parte da f�sica que estuda a energia t�rmica?",
                    Resposta = "Termologia",
                    erradoA = "Magnetismo",
                    erradoB = "Mec�nica",
                    erradoC = "Eletricidade",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Quanto equivale 373 Kelvin na escala Celsius?",
                    Resposta = "100�C",
                    erradoA = "90�C",
                    erradoB = "0�C",
                    erradoC = "125�C",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "O g�s de cozinha possui nome e f�rmula:",
                    Resposta = "Butano - C4H10",
                    erradoA = "Metano - CH4",
                    erradoB = "Etano - C2H6",
                    erradoC = "Pentano - C5H12",
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
                    Questao = "Diferente do que o conhecimento popular diz, a feijoada n�o foi criada por escravos. Em que pa�s foi inventada a feijoada?",
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
                    Questao = "Qual o nome da espada do personagem principal no jogo Final Fantasy VII?",
                    Resposta = "Buster Sword",
                    erradoA = "Excalibur",
                    erradoB = "Murasame",
                    erradoC = "Unbinding Sword",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do principal reino da s�rie The Legend of Zelda?",
                    Resposta = "Hyrule",
                    erradoA = "Obsydia",
                    erradoB = "Baron",
                    erradoC = "Mushroom",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do irm�o de Mario na s�rie Super Mario Bros.?",
                    Resposta = "Luigi",
                    erradoA = "Alfredo",
                    erradoB = "Lorenzo",
                    erradoC = "Pietro",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Como � conhecido o personagem principal do universo fict�cio do jogo Halo?",
                    Resposta = "Master Chief",
                    erradoA = "Master Leader",
                    erradoB = "Major Connor",
                    erradoC = "Officer John",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Em qual desses jogos, salvar a princesa n�o � um dos objetivos?",
                    Resposta = "Castlevania: Symphony of the Night",
                    erradoA = "Super Mario World",
                    erradoB = "The Legend of Zelda: Minish Cap",
                    erradoC = "Castle Crashers",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o significado do termo RPG(g�nero)?",
                    Resposta = "Role Playing Game",
                    erradoA = "Recovery Point Game",
                    erradoB = "Rocket-Propelled Grenade",
                    erradoC = "Robbery Package Game",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo Pok�mon Red, quem � o l�der do gin�sio da cidade de Cinnabar?",
                    Resposta = "Blaine",
                    erradoA = "Brock",
                    erradoB = "Gary",
                    erradoC = "Erika",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo The Elder Scrolls V: Skyrim, quais s�o as palavras para o Shout Unrelenting Force?",
                    Resposta = "Fus Ro Dah",
                    erradoA = "Iiz Slen Nus",
                    erradoB = "Od Ah Viing",
                    erradoC = "Joor Zah Frul",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do personagem principal de Grand Theft Auto San Andreas?",
                    Resposta = "Carl Johnson",
                    erradoA = "Sweet Johnson",
                    erradoB = "Madd Dogg",
                    erradoC = "Salvatore Leone",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Em que reino � ambientado o jogo Dark Souls?",
                    Resposta = "Lordran",
                    erradoA = "Gurran",
                    erradoB = "Mattrov",
                    erradoC = "Orience",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do antagonista do jogo Banjo-Tooie?",
                    Resposta = "Gruntilda",
                    erradoA = "Mingruge",
                    erradoB = "Blobbelda",
                    erradoC = "Mingella",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Na s�rie de jogos Crash Bandicoot, quem � Aku Aku?",
                    Resposta = "A m�scara tribal que acompanha Crash",
                    erradoA = "O dr. do mal, antagonista do jogo",
                    erradoB = "A irm� de Crash",
                    erradoC = "O Chefe que o ataca com um lan�a-chamas",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Com que t�tulo o jogo Shadow of The Colossus foi lan�ado no Jap�o?",
                    Resposta = "Wander and the Colossus",
                    erradoA = "Darkness of Colossus",
                    erradoB = "Nightmare Colossus",
                    erradoC = "The Legend of Colossus",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo God of War, qual � o nome das l�minas principais usadas pro Kratos?",
                    Resposta = "L�minas do Caos",
                    erradoA = "L�minas de Artemis",
                    erradoB = "L�minas dos Deuses",
                    erradoC = "L�minas de Ares",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Na s�rie Sonic The Hedgehog, quem � o melhor amigo e ajudante de Sonic?",
                    Resposta = "Tails",
                    erradoA = "Knuckles",
                    erradoB = "Shadow",
                    erradoC = "Amy",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Como � conhecido Mega man no Jap�o?",
                    Resposta = "Rockman",
                    erradoA = "Shootman",
                    erradoB = "Ultra man",
                    erradoC = "Cannon man",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o principal poder do p�ssaro preto no jogo Angry Birds?",
                    Resposta = "Explodir",
                    erradoA = "Soltar um ovo explosivo",
                    erradoB = "Partir madeira com facilidade",
                    erradoC = "Partir vidro com facilidade",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo Clash of Clans, qual o nome do l�quido rosado utilizado como recurso?",
                    Resposta = "Elixir",
                    erradoA = "Goma de mascar",
                    erradoB = "Po��o",
                    erradoC = "L�quido energ�tico",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome da s�rie de jogos da Nintendo cujos personagens s�o macacos?",
                    Resposta = "Donkey Kong",
                    erradoA = "King Kong",
                    erradoB = "Kong Lord",
                    erradoC = "Banana Kong",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do protagonista da s�rie Half Life?",
                    Resposta = "Gordon Freeman",
                    erradoA = "Gordon Mccartney",
                    erradoB = "Gordon Lee",
                    erradoC = "Gordon Smith",
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


            context.Pontuacaos.AddOrUpdate(
                p => p.Usuario,
                new Pontuacao
                {
                    Usuario = "arionildo@escouto.com",
                    Pontos = 500,
                    NomeCategoria = "Ci�ncia",
                    Data = new DateTime(2015, 06, 15, 15, 51, 56)
                },
                  new Pontuacao
                  {
                      Usuario = "joao@hotmail.com",
                      Pontos = 100,
                      NomeCategoria = "Ci�ncia",
                      Data = new DateTime(2015, 06, 14, 12, 31, 26)
                  },
                  new Pontuacao
                  {
                      Usuario = "joao@hotmail.com",
                      Pontos = 650,
                      NomeCategoria = "Ci�ncia",
                      Data = new DateTime(2015, 06, 14, 12, 36, 26)
                  },
                  new Pontuacao
                  {
                      Usuario = "talles@hotmail.com",
                      Pontos = 740,
                      NomeCategoria = "Ci�ncia",
                      Data = new DateTime(2015, 06, 16, 00, 01, 26)
                  }


            );
        }
    }
}
