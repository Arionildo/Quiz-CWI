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

  

        public ActionResult Perguntas(int? id)
        {
            var aa = db.Perguntas.Where(x => x.Categoria.Id == id);


            return View(aa);
        }

             
           
    }
}