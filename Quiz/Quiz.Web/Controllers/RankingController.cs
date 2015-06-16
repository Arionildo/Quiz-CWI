using Quiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz.Web.Controllers
{
    public class RankingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Ranking
        public ActionResult CategoiraRank()
        {
            return View(db.Categorias.ToList());
        }


        public ActionResult Index(int id)
        
        {
           


            return View(db.Pontuacaos.Where(x => x.Pontos == (db.Pontuacaos.Where(a => a.Usuario == x.Usuario && a.Categoria.Id == id).Select(a => new { a.Pontos }).OrderByDescending(c => c.Pontos).FirstOrDefault()).Pontos).OrderByDescending(x => x.Pontos) );
        }
    }
}