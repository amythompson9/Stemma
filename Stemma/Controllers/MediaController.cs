using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stemma.Models;

namespace Stemma.Controllers
{
    public class MediaController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: Media
        public ActionResult Index()
        {
            var media = db.Media.Include(m => m.EventTable);
            return View(media.ToList());
        }

        // GET: Media/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medium medium = db.Media.Find(id);
            if (medium == null)
            {
                return HttpNotFound();
            }
            return View(medium);
        }

        // GET: Media/Create
        public ActionResult Create()
        {
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle");
            return View();
        }

        // POST: Media/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MediaID,FilePath,EventID")] Medium medium)
        {
            if (ModelState.IsValid)
            {
                db.Media.Add(medium);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", medium.EventID);
            return View(medium);
        }

        // GET: Media/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medium medium = db.Media.Find(id);
            if (medium == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", medium.EventID);
            return View(medium);
        }

        // POST: Media/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MediaID,FilePath,EventID")] Medium medium)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medium).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", medium.EventID);
            return View(medium);
        }

        // GET: Media/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medium medium = db.Media.Find(id);
            if (medium == null)
            {
                return HttpNotFound();
            }
            return View(medium);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Medium medium = db.Media.Find(id);
            db.Media.Remove(medium);
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
