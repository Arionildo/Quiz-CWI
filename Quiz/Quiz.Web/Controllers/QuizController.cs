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
           
    }
}