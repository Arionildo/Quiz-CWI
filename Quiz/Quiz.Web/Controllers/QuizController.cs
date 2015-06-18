using Quiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Quiz.Web.Controllers
{
    public class QuizController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Quiz
        public ActionResult Index()
        {
       

            return View(db.Categorias.ToList());


        }


        public ActionResult Details(int? id, int? dificuldade)
        {
            @ViewBag.id = id;
            @ViewBag.dificuldade = dificuldade;
        
            return View();
        }


        [AllowAnonymous]
        public JsonResult Perguntas(int id, int dificuldade)
        {


            if (id == 3)
            {
                 var retornoPerguntas = db.Perguntas.Where(x =>x.dificuldade == dificuldade).Select(x => new { x.Questao, x.Resposta, x.erradoA, x.erradoB, x.erradoC }); //;
                 return Json(retornoPerguntas, JsonRequestBehavior.AllowGet);

            }
            else 
            {
                var retornoPerguntas = db.Perguntas.Where(x => x.Categoria_Id == id && x.dificuldade == dificuldade).Select(x => new { x.Questao, x.Resposta, x.erradoA, x.erradoB, x.erradoC }); //;
                return Json(retornoPerguntas, JsonRequestBehavior.AllowGet);

            }


          
        }

 

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult Pontuacao([Bind(Include = "Id,Usuario,Pontos")] Pontuacao pontuacao, int cat)
        {
            pontuacao.NomeCategoria = db.Categorias.Where(x => x.Id == cat).Select(y => y.Nome).First();
            pontuacao.Data = DateTime.Now;
            //PROCURA A CATEGORIA PELO ID PARA OBTER A CATEGORIA COMPLETA
            pontuacao.Categoria = db.Categorias.Find(cat);

            //PERSISTE OS DADOS NO BANCO
            db.Pontuacaos.Add(pontuacao);
            db.SaveChanges();

            return Json(new {
                u = pontuacao.Usuario,
                c = pontuacao.NomeCategoria,
                p = pontuacao.Pontos
            });
        }
           
    }
}