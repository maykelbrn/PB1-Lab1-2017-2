using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaWebApp.Models;

namespace ProvaWebApp.Controllers
{
    public class AutomovelController : Controller
    {
        private AutomovelContext db = new AutomovelContext();

        // GET: Automovel
        public ActionResult Index()
        {
            return View(db.Automovels.ToList());
        }

        // GET: Automovel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automovels.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            return View(automovel);
        }

        // GET: Automovel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automovel/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutomovelId,Tipo,Descricao,Marca,Disponivel,DataCadastro")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                db.Automovels.Add(automovel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(automovel);
        }

        // GET: Automovel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automovels.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            return View(automovel);
        }

        // POST: Automovel/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutomovelId,Tipo,Descricao,Marca,Disponivel,DataCadastro")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automovel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(automovel);
        }

        // GET: Automovel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automovels.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            return View(automovel);
        }

        // POST: Automovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automovel automovel = db.Automovels.Find(id);
            db.Automovels.Remove(automovel);
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
