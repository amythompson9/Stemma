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
    public class RelationshipsController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        public bool CurrentlyMarried { get; private set; }
        public bool InARelationship { get; private set; }
        public bool PreviousRomance { get; private set; }
        public bool HaveChildren { get; private set; }
        public bool HaveGrandchildren { get; private set; }
        public bool OtherYoungsters { get; private set; }
        public bool HaveParents { get; private set; }
        public bool HaveGrandparents { get; private set; }
        public bool OtherAdults { get; private set; }
        public bool HaveSiblings { get; private set; }
        public bool OtherCloseRelatives { get; private set; }
        public bool GoodFriendships { get; private set; }
        public bool EverythingElse { get; private set; }

        // GET: Relationships
        public ActionResult Index()
        {
            return View(db.Relationships.ToList());
        }

        // GET: Relationships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relationship relationship = db.Relationships.Find(id);
            if (relationship == null)
            {
                return HttpNotFound();
            }
            return View(relationship);
        }

        // GET: Relationships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RelationshipsID,CurrentlyMarried,InARelationship,PreviousRomance,HaveChildren,HaveGrandchildren,OtherYoungsters,HaveParents,HaveGrandparents,OtherAdults,HaveSiblings,OtherCloseRelatives,GoodFriendships,EverythingElse")] Relationship relationship)
        {
            if (ModelState.IsValid)
            {
                db.Relationships.Add(relationship);
                db.SaveChanges();
                //next line changed from Index to Details with ID
                return RedirectToAction("Details", new { id = relationship.RelationshipsID });
            }

            return View(relationship);
        }

        // GET: Relationships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relationship relationship = db.Relationships.Find(id);
            if (relationship == null)
            {
                return HttpNotFound();
            }
            return View(relationship);
        }

        // POST: Relationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RelationshipsID,CurrentlyMarried,InARelationship,PreviousRomance,HaveChildren,HaveGrandchildren,OtherYoungsters,HaveParents,HaveGrandparents,OtherAdults,HaveSiblings,OtherCloseRelatives,GoodFriendships,EverythingElse")] Relationship relationship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relationship).State = EntityState.Modified;
                db.SaveChanges();
                //next line changed from Index to Details with ID
                return RedirectToAction("Details", new { id = relationship.RelationshipsID });
            }
            return View(relationship);
        }

        // GET: Relationships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relationship relationship = db.Relationships.Find(id);
            if (relationship == null)
            {
                return HttpNotFound();
            }
            return View(relationship);
        }

        // POST: Relationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Relationship relationship = db.Relationships.Find(id);
            db.Relationships.Remove(relationship);
            db.SaveChanges();
            //next line changed from Index to Create
            return RedirectToAction("Create");
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
