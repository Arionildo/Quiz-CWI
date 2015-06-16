using Quiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

            var myDate = DateTime.Today.AddDays(1);
            var week = myDate.AddDays(-(int)myDate.DayOfWeek);
            var Mounth = myDate.AddDays(-(int)myDate.Day);

    

            
           var  rankSemana = db.Pontuacaos.Where(x => x.Pontos == (db.Pontuacaos.Where(a => a.Usuario == x.Usuario && a.Categoria.Id == id && a.Data <= myDate && a.Data >= week).Select(a => new { a.Pontos }).OrderByDescending(c => c.Pontos).FirstOrDefault()).Pontos).OrderByDescending(x => x.Pontos);
           var rankMes = db.Pontuacaos.Where(x => x.Pontos == (db.Pontuacaos.Where(a => a.Usuario == x.Usuario && a.Categoria.Id == id && a.Data <= myDate && a.Data >= week).Select(a => new { a.Pontos }).OrderByDescending(c => c.Pontos).FirstOrDefault()).Pontos).OrderByDescending(x => x.Pontos);


           var model = new Dictionary<String, IEnumerable<Pontuacao>>();
           model.Add("rankSemana", rankSemana);
           model.Add("rankMes", rankMes);

     
           return View(model);
        }

    }
}