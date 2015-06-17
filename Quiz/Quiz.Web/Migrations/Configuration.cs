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
                new Categoria { Nome = "Ciência", Descricao = "Dos elementos que nos compõe até a física que nos segura na terra." },
                new Categoria { Nome = "Comidas E Bebidas", Descricao = "Desde os ingredientes à diversos pratos e bebidas existentes ao redor do mundo." },
                new Categoria { Nome = "Conhecimentos Gerais", Descricao = "Mistura de todos os assuntos das mais diversas áreas." },
                new Categoria { Nome = "Esportes", Descricao = "Todas as modalidades, do mais leve ao mais radical." },
                new Categoria { Nome = "Filme", Descricao = "Tudo sobre filmes, atores e, quem sabe, até diretores!" },
                new Categoria { Nome = "Geografia", Descricao = "Lugares, climas, vegetações e tudo mais que a natureza tem a oferecer." },
                new Categoria { Nome = "Jogos", Descricao = "'Piece of cake' para os mais aficionados em jogos, seus personagens e suas histórias." },
                new Categoria { Nome = "Música", Descricao = "Questões relacionadas à bandas, cantores e todos os estilos musicais." },
                new Categoria { Nome = "TV", Descricao = "Para aqueles quem não perdem uma novela, uma série ou até mesmo um programa de celebridades." }
            );


            context.Perguntas.AddOrUpdate(
                p => p.Questao,

            #region Ciência
                new Pergunta
                {
                    Questao = "Que tipo de rocha é a pedra mármore?",
                    Resposta = "Metamórfica",
                    erradoA = "Magmática",
                    erradoB = "Sedimentar",
                    erradoC = "Rudimentar",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Como se chama um lugar onde animais e plantas coabitam?",
                    Resposta = "Habitat",
                    erradoA = "Jardim botânico",
                    erradoB = "Casa",
                    erradoC = "Natureza",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "De que cor é a lingua da girafa?",
                    Resposta = "Azul",
                    erradoA = "Verde",
                    erradoB = "Amarela",
                    erradoC = "Vermelha",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Por quantas camadas é constituida a atmosfera?",
                    Resposta = "5 camadas",
                    erradoA = "2 camadas",
                    erradoB = "1 camada",
                    erradoC = "7 camadas",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "A lua não produz luz mas, mesmo assim, brilha à noite. Porquê?",
                    Resposta = "Porque reflete a luz do sol",
                    erradoA = "Pois gira a uma velocidade altíssima",
                    erradoB = "Pois possui várias crateras",
                    erradoC = "Porque é coberta por uma fina camada de gelo",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual o nome do processo natural que transforma o vapor em água?",
                    Resposta = "Liquefação",
                    erradoA = "Fusão",
                    erradoB = "Calefação",
                    erradoC = "Solidificação",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual gás está presente em maior quantidade na atmosfera terrestre?",
                    Resposta = "Nitrogênio",
                    erradoA = "Gas carbônico",
                    erradoB = "Oxigênio",
                    erradoC = "Hidrogênio",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Qual a parte da física que estuda a energia térmica?",
                    Resposta = "Termologia",
                    erradoA = "Magnetismo",
                    erradoB = "Mecânica",
                    erradoC = "Eletricidade",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "Quanto equivale 373 Kelvin na escala Celsius?",
                    Resposta = "100°C",
                    erradoA = "90°C",
                    erradoB = "0°C",
                    erradoC = "125°C",
                    Categoria_Id = 1
                },
                new Pergunta
                {
                    Questao = "O gás de cozinha possui nome e fórmula:",
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
                    Questao = "A Caipirinha é uma das bebidas brasileiras mais conhecidas nacionalmente e internacionalmente. A Caipirinha tem origem de qual estado brasileiro?",
                    Resposta = "Mato Grosso do Sul",
                    erradoA = "Espírito Santo",
                    erradoB = "São Paulo",
                    erradoC = "Pernambuco",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "O verdadeiro churrasco tradicional do Rio Grande do Sul é temperado, essencialmente, com:",
                    Resposta = "Sal grosso",
                    erradoA = "Vinho tinto",
                    erradoB = "Azeite de oliva",
                    erradoC = "Limão",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Diferente do que o conhecimento popular diz, a feijoada não foi criada por escravos. Em que país foi inventada a feijoada?",
                    Resposta = "Portugal",
                    erradoA = "Alemanha",
                    erradoB = "Itália",
                    erradoC = "Eslovênia",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual a comida mais popular para mais da metade da população mundial?",
                    Resposta = "Arroz",
                    erradoA = "Macarrão",
                    erradoB = "Feijão",
                    erradoC = "Frango",
                    Categoria_Id = 2
                },
                new Pergunta
                {
                    Questao = "Qual rio escocês fornece mais de 90% da água usada na fabricação de Whisky?",
                    Resposta = "Spey",
                    erradoA = "Weser",
                    erradoB = "Volga",
                    erradoC = "Danúbio",
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
                    Questao = "Qual o nome da espada do personagem principal no jogo Final Fantasy VII?",
                    Resposta = "Buster Sword",
                    erradoA = "Excalibur",
                    erradoB = "Murasame",
                    erradoC = "Unbinding Sword",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do principal reino da série The Legend of Zelda?",
                    Resposta = "Hyrule",
                    erradoA = "Obsydia",
                    erradoB = "Baron",
                    erradoC = "Mushroom",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do irmão de Mario na série Super Mario Bros.?",
                    Resposta = "Luigi",
                    erradoA = "Alfredo",
                    erradoB = "Lorenzo",
                    erradoC = "Pietro",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Como é conhecido o personagem principal do universo fictício do jogo Halo?",
                    Resposta = "Master Chief",
                    erradoA = "Master Leader",
                    erradoB = "Major Connor",
                    erradoC = "Officer John",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Em qual desses jogos, salvar a princesa não é um dos objetivos?",
                    Resposta = "Castlevania: Symphony of the Night",
                    erradoA = "Super Mario World",
                    erradoB = "The Legend of Zelda: Minish Cap",
                    erradoC = "Castle Crashers",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o significado do termo RPG(gênero)?",
                    Resposta = "Role Playing Game",
                    erradoA = "Recovery Point Game",
                    erradoB = "Rocket-Propelled Grenade",
                    erradoC = "Robbery Package Game",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo Pokémon Red, quem é o líder do ginásio da cidade de Cinnabar?",
                    Resposta = "Blaine",
                    erradoA = "Brock",
                    erradoB = "Gary",
                    erradoC = "Erika",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo The Elder Scrolls V: Skyrim, quais são as palavras para o Shout Unrelenting Force?",
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
                    Questao = "Em que reino é ambientado o jogo Dark Souls?",
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
                    Questao = "Na série de jogos Crash Bandicoot, quem é Aku Aku?",
                    Resposta = "A máscara tribal que acompanha Crash",
                    erradoA = "O dr. do mal, antagonista do jogo",
                    erradoB = "A irmã de Crash",
                    erradoC = "O Chefe que o ataca com um lança-chamas",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Com que título o jogo Shadow of The Colossus foi lançado no Japão?",
                    Resposta = "Wander and the Colossus",
                    erradoA = "Darkness of Colossus",
                    erradoB = "Nightmare Colossus",
                    erradoC = "The Legend of Colossus",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo God of War, qual é o nome das lâminas principais usadas pro Kratos?",
                    Resposta = "Lâminas do Caos",
                    erradoA = "Lâminas de Artemis",
                    erradoB = "Lâminas dos Deuses",
                    erradoC = "Lâminas de Ares",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Na série Sonic The Hedgehog, quem é o melhor amigo e ajudante de Sonic?",
                    Resposta = "Tails",
                    erradoA = "Knuckles",
                    erradoB = "Shadow",
                    erradoC = "Amy",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Como é conhecido Mega man no Japão?",
                    Resposta = "Rockman",
                    erradoA = "Shootman",
                    erradoB = "Ultra man",
                    erradoC = "Cannon man",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o principal poder do pássaro preto no jogo Angry Birds?",
                    Resposta = "Explodir",
                    erradoA = "Soltar um ovo explosivo",
                    erradoB = "Partir madeira com facilidade",
                    erradoC = "Partir vidro com facilidade",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "No jogo Clash of Clans, qual o nome do líquido rosado utilizado como recurso?",
                    Resposta = "Elixir",
                    erradoA = "Goma de mascar",
                    erradoB = "Poção",
                    erradoC = "Líquido energético",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome da série de jogos da Nintendo cujos personagens são macacos?",
                    Resposta = "Donkey Kong",
                    erradoA = "King Kong",
                    erradoB = "Kong Lord",
                    erradoC = "Banana Kong",
                    Categoria_Id = 7
                },
                new Pergunta
                {
                    Questao = "Qual o nome do protagonista da série Half Life?",
                    Resposta = "Gordon Freeman",
                    erradoA = "Gordon Mccartney",
                    erradoB = "Gordon Lee",
                    erradoC = "Gordon Smith",
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


            context.Pontuacaos.AddOrUpdate(
                p => p.Usuario,
                new Pontuacao
                {
                    Usuario = "arionildo@escouto.com",
                    Pontos = 500,
                    NomeCategoria = "Ciência",
                    Data = new DateTime(2015, 06, 15, 15, 51, 56)
                },
                  new Pontuacao
                  {
                      Usuario = "joao@hotmail.com",
                      Pontos = 100,
                      NomeCategoria = "Ciência",
                      Data = new DateTime(2015, 06, 14, 12, 31, 26)
                  },
                  new Pontuacao
                  {
                      Usuario = "joao@hotmail.com",
                      Pontos = 650,
                      NomeCategoria = "Ciência",
                      Data = new DateTime(2015, 06, 14, 12, 36, 26)
                  },
                  new Pontuacao
                  {
                      Usuario = "talles@hotmail.com",
                      Pontos = 740,
                      NomeCategoria = "Ciência",
                      Data = new DateTime(2015, 06, 16, 00, 01, 26)
                  }


            );
        }
    }
}
