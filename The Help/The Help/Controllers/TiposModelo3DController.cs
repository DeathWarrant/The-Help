using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using The_Help.Models;
using The_Help.Models.Contexto;

namespace The_Help.Controllers
{
    public class TiposModelo3DController : Controller
    {
        private Contexto db = new Contexto();

        // GET: TiposModelo3D
        public ActionResult Index()
        {
            return View(db.TipoModelo3D.ToList());
        }

        // GET: TiposModelo3D/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoModelo3D tipoModelo3D = db.TipoModelo3D.Find(id);
            if (tipoModelo3D == null)
            {
                return HttpNotFound();
            }
            return View(tipoModelo3D);
        }

        // GET: TiposModelo3D/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposModelo3D/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoModelo3DID,Nome")] TipoModelo3D tipoModelo3D)
        {
            if (ModelState.IsValid)
            {
                db.TipoModelo3D.Add(tipoModelo3D);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoModelo3D);
        }

        // GET: TiposModelo3D/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoModelo3D tipoModelo3D = db.TipoModelo3D.Find(id);
            if (tipoModelo3D == null)
            {
                return HttpNotFound();
            }
            return View(tipoModelo3D);
        }

        // POST: TiposModelo3D/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoModelo3DID,Nome")] TipoModelo3D tipoModelo3D)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoModelo3D).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoModelo3D);
        }

        // GET: TiposModelo3D/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoModelo3D tipoModelo3D = db.TipoModelo3D.Find(id);
            if (tipoModelo3D == null)
            {
                return HttpNotFound();
            }
            return View(tipoModelo3D);
        }

        // POST: TiposModelo3D/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoModelo3D tipoModelo3D = db.TipoModelo3D.Find(id);
            db.TipoModelo3D.Remove(tipoModelo3D);
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
