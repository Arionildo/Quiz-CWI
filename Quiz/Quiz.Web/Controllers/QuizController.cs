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

 
        public ActionResult Details(int? id)
        {
            @ViewBag.id = id;
        
            return View();
        }


        [AllowAnonymous]
        public JsonResult Perguntas(int? id)
        {
           
            var retornoPerguntas = db.Perguntas.Where(x => x.Categoria_Id == id).Select(x => new { x.Questao, x.Resposta, x.erradoA, x.erradoB, x.erradoC }); //;

            return Json(retornoPerguntas, JsonRequestBehavior.AllowGet);

          
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