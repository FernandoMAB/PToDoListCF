﻿using System;
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
    public class CitasController : Controller
    {
        private ToDoList db = new ToDoList();

        // GET: Citas
        public ActionResult Index()
        {
            var citas = db.Citas.Include(c => c.Medico).Include(c => c.Usersxd);
            return View(citas.ToList());
        }

        // GET: Citas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            return View(citas);
        }

        // GET: Citas/Create
        public ActionResult Create()
        {
            ViewBag.MedicoID = new SelectList(db.Medico, "MedicoID", "nombre");
            ViewBag.UsersxdID = new SelectList(db.Usersxd, "UsersxdID", "name");
            return View();
        }

        // POST: Citas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CitasID,MedicoID,UsersxdID,Nombre_Usuario,Nombre_Medico,Fecha,Tiempo")] Citas citas)
        {
            if (ModelState.IsValid)
            {
                db.Citas.Add(citas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MedicoID = new SelectList(db.Medico, "MedicoID", "nombre", citas.MedicoID);
            ViewBag.UsersxdID = new SelectList(db.Usersxd, "UsersxdID", "name", citas.UsersxdID);
            return View(citas);
        }

        // GET: Citas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            ViewBag.MedicoID = new SelectList(db.Medico, "MedicoID", "nombre", citas.MedicoID);
            ViewBag.UsersxdID = new SelectList(db.Usersxd, "UsersxdID", "name", citas.UsersxdID);
            return View(citas);
        }

        // POST: Citas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CitasID,MedicoID,UsersxdID,Nombre_Usuario,Nombre_Medico,Fecha,Tiempo")] Citas citas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MedicoID = new SelectList(db.Medico, "MedicoID", "nombre", citas.MedicoID);
            ViewBag.UsersxdID = new SelectList(db.Usersxd, "UsersxdID", "name", citas.UsersxdID);
            return View(citas);
        }

        // GET: Citas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            return View(citas);
        }

        // POST: Citas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Citas citas = db.Citas.Find(id);
            db.Citas.Remove(citas);
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
