using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PToDoListCF.Models;

namespace PToDoListCF.Controllers
{
    public class UsersxdsController : Controller
    {
        private ToDoList db = new ToDoList();

        // GET: Usersxds
        public ActionResult Index()
        {
            return View(db.Usersxd.ToList());
        }

        // GET: Usersxds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usersxd usersxd = db.Usersxd.Find(id);
            if (usersxd == null)
            {
                return HttpNotFound();
            }
            return View(usersxd);
        }

        // GET: Usersxds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usersxds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsersxdID,name,edad,email,password,celular,cedula")] Usersxd usersxd)
        {
            if (ModelState.IsValid)
            {
                db.Usersxd.Add(usersxd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usersxd);
        }

        // GET: Usersxds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usersxd usersxd = db.Usersxd.Find(id);
            if (usersxd == null)
            {
                return HttpNotFound();
            }
            return View(usersxd);
        }

        // POST: Usersxds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsersxdID,name,edad,email,password,celular,cedula")] Usersxd usersxd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usersxd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usersxd);
        }

        // GET: Usersxds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usersxd usersxd = db.Usersxd.Find(id);
            if (usersxd == null)
            {
                return HttpNotFound();
            }
            return View(usersxd);
        }

        // POST: Usersxds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usersxd usersxd = db.Usersxd.Find(id);
            db.Usersxd.Remove(usersxd);
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
