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
    public class MemoriesController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: Memories
        public ActionResult Index()
        {
            return View(db.Memories.ToList());
        }

        // GET: Memories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memories.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // GET: Memories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemoryID,BrokenBones,OwnHome,DriversLicense,FirstTooth,PersonalNickName,FamilyNickName,RideBike,CommitCrime,BigMove,Vote,FamilyTraditions,EmbarrassingMoment,ProudestMoments,ChildhoodCamp,MemorializeSomeone,Concerts,FamilyPet,CurrentPet,HSDance,AnythingElse")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                db.Memories.Add(memory);
                db.SaveChanges();
                //next line changes Index to Details and id .
                return RedirectToAction("Details", new { id = memory.MemoryID });
            }

            return View(memory);
        }

        // GET: Memories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memories.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // POST: Memories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemoryID,BrokenBones,OwnHome,DriversLicense,FirstTooth,PersonalNickName,FamilyNickName,RideBike,CommitCrime,BigMove,Vote,FamilyTraditions,EmbarrassingMoment,ProudestMoments,ChildhoodCamp,MemorializeSomeone,Concerts,FamilyPet,CurrentPet,HSDance,AnythingElse")] Memory memory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(memory).State = EntityState.Modified;
                db.SaveChanges();
                //next line changed Index to Details and id
                return RedirectToAction("Details", new { id = memory.MemoryID });
            }
            return View(memory);
        }

        // GET: Memories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Memory memory = db.Memories.Find(id);
            if (memory == null)
            {
                return HttpNotFound();
            }
            return View(memory);
        }

        // POST: Memories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Memory memory = db.Memories.Find(id);
            db.Memories.Remove(memory);
            db.SaveChanges();
            //next line changed Index to Create
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
