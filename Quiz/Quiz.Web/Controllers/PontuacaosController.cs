using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quiz.Web.Models;

namespace Quiz.Web.Controllers
{
    public class PontuacaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pontuacaos
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(db.Pontuacaos.ToList());
        }

        // GET: Pontuacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pontuacao pontuacao = db.Pontuacaos.Find(id);
            if (pontuacao == null)
            {
                return HttpNotFound();
            }
            return View(pontuacao);
        }

        // GET: Pontuacaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pontuacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Usuario,pontos,Data")] Pontuacao pontuacao)
        {
            if (ModelState.IsValid)
            {
                db.Pontuacaos.Add(pontuacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pontuacao);
        }

        // GET: Pontuacaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pontuacao pontuacao = db.Pontuacaos.Find(id);
            if (pontuacao == null)
            {
                return HttpNotFound();
            }
            return View(pontuacao);
        }

        // POST: Pontuacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Usuario_Id,pontos,Data")] Pontuacao pontuacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pontuacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pontuacao);
        }

        // GET: Pontuacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pontuacao pontuacao = db.Pontuacaos.Find(id);
            if (pontuacao == null)
            {
                return HttpNotFound();
            }
            return View(pontuacao);
        }

        // POST: Pontuacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pontuacao pontuacao = db.Pontuacaos.Find(id);
            db.Pontuacaos.Remove(pontuacao);
            db.SaveChanges();
            return RedirectToAction("Index");
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
