
using Quiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
﻿
namespace Quiz.Web
{
    public class Categoria : Entidade
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public ICollection<Pergunta> Pergunta { get; set; }

        //RETORNA UMA LISTA COM O ID E NOME DE CADA CATEGORIA
        public SelectList GetCategorias()
        {
            var lista = db.Categorias.Select(x =>
                                new SelectListItem
                                {
                                    Value = x.Nome,
                                    Text = x.Nome
                                });

            return new SelectList(lista, "Value", "Text");
        }

        //RETORNA O NOME DA CADA CATEGORIA DE ACORDO COM O ID
        public string GetNomeCategoria(int id)
        {
            return db.Categorias.Where(x => x.Id == id).Select(y => y.Nome).First();
        }

        public int GetCategoria()
        {
            var lista = db.Categorias.Select(x => x.Id).ToList();
            var rnd = new Random();
            var categoria = lista[rnd.Next(1, lista.Count)];

            return categoria;
        }
    }
}

