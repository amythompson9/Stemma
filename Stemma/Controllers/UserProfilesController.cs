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
    public class UserProfilesController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: UserProfiles
        public ActionResult Index()
        {
            var userProfiles = db.UserProfiles.Include(u => u.Career).Include(u => u.Celebration).Include(u => u.HobbyTable).Include(u => u.Memory).Include(u => u.Relationship).Include(u => u.WorldEvent).Include(u => u.EventTable);
            return View(userProfiles.ToList());
        }

        // GET: UserProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // GET: UserProfiles/Create
        public ActionResult Create()
        {
            ViewBag.CareerID = new SelectList(db.Careers, "CareerID", "CareerID");
            ViewBag.CelebrationID = new SelectList(db.Celebrations, "CelebrationID", "CelebrationID");
            ViewBag.HobbyID = new SelectList(db.HobbyTables, "HobbyID", "HobbyID");
            ViewBag.MemoryID = new SelectList(db.Memories, "MemoryID", "MemoryID");
            ViewBag.RelationshipsID = new SelectList(db.Relationships, "RelationshipsID", "RelationshipsID");
            ViewBag.WorldEventID = new SelectList(db.WorldEvents, "WorldEventID", "WorldEventID");
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle");
            return View();
        }

        // POST: UserProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserProfileID,Birthdate,RegisterUserID,RelationshipsID,CareerID,CelebrationID,HobbyID,MemoryID,WorldEventID,EventID")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db.UserProfiles.Add(userProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CareerID = new SelectList(db.Careers, "CareerID", "CareerID", userProfile.CareerID);
            ViewBag.CelebrationID = new SelectList(db.Celebrations, "CelebrationID", "CelebrationID", userProfile.CelebrationID);
            ViewBag.HobbyID = new SelectList(db.HobbyTables, "HobbyID", "HobbyID", userProfile.HobbyID);
            ViewBag.MemoryID = new SelectList(db.Memories, "MemoryID", "MemoryID", userProfile.MemoryID);
            ViewBag.RelationshipsID = new SelectList(db.Relationships, "RelationshipsID", "RelationshipsID", userProfile.RelationshipsID);
            ViewBag.WorldEventID = new SelectList(db.WorldEvents, "WorldEventID", "WorldEventID", userProfile.WorldEventID);
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", userProfile.EventID);
            return View(userProfile);
        }

        // GET: UserProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            ViewBag.CareerID = new SelectList(db.Careers, "CareerID", "CareerID", userProfile.CareerID);
            ViewBag.CelebrationID = new SelectList(db.Celebrations, "CelebrationID", "CelebrationID", userProfile.CelebrationID);
            ViewBag.HobbyID = new SelectList(db.HobbyTables, "HobbyID", "HobbyID", userProfile.HobbyID);
            ViewBag.MemoryID = new SelectList(db.Memories, "MemoryID", "MemoryID", userProfile.MemoryID);
            ViewBag.RelationshipsID = new SelectList(db.Relationships, "RelationshipsID", "RelationshipsID", userProfile.RelationshipsID);
            ViewBag.WorldEventID = new SelectList(db.WorldEvents, "WorldEventID", "WorldEventID", userProfile.WorldEventID);
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", userProfile.EventID);
            return View(userProfile);
        }

        // POST: UserProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserProfileID,Birthdate,RegisterUserID,RelationshipsID,CareerID,CelebrationID,HobbyID,MemoryID,WorldEventID,EventID")] UserProfile userProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CareerID = new SelectList(db.Careers, "CareerID", "CareerID", userProfile.CareerID);
            ViewBag.CelebrationID = new SelectList(db.Celebrations, "CelebrationID", "CelebrationID", userProfile.CelebrationID);
            ViewBag.HobbyID = new SelectList(db.HobbyTables, "HobbyID", "HobbyID", userProfile.HobbyID);
            ViewBag.MemoryID = new SelectList(db.Memories, "MemoryID", "MemoryID", userProfile.MemoryID);
            ViewBag.RelationshipsID = new SelectList(db.Relationships, "RelationshipsID", "RelationshipsID", userProfile.RelationshipsID);
            ViewBag.WorldEventID = new SelectList(db.WorldEvents, "WorldEventID", "WorldEventID", userProfile.WorldEventID);
            ViewBag.EventID = new SelectList(db.EventTables, "EventID", "EventTitle", userProfile.EventID);
            return View(userProfile);
        }

        // GET: UserProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserProfile userProfile = db.UserProfiles.Find(id);
            if (userProfile == null)
            {
                return HttpNotFound();
            }
            return View(userProfile);
        }

        // POST: UserProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserProfile userProfile = db.UserProfiles.Find(id);
            db.UserProfiles.Remove(userProfile);
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
