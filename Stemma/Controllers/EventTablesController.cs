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
    public class EventTablesController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: EventTables
        public ActionResult Index()
        {
            //you are trying to add a sorting feature :(


            var queryWholeTimeline = from EventTable in db.EventTables
                                     orderby
                                     //you changed one "descending" to 3 "ascending"
                                       EventTable.EventYear descending,
                                       EventTable.EventMonth descending,
                                       EventTable.EventDay descending
                                     select EventTable;

            //select new
            //{
            //    EventID = EventTable.EventID,
            //    DateCreated = EventTable.DateCreated,
            //    EventTitle = EventTable.EventTitle,
            //    EventDay = EventTable.EventDay,
            //    EventMonth = EventTable.EventMonth,
            //    EventYear = EventTable.EventYear,
            //    PeopleInvolved = EventTable.PeopleInvolved,
            //    EventCaption = EventTable.EventCaption
            //};

            //try this instead:
            //select EventTable;
            //apparently, nope.

            //foreach (var timePoint in queryWholeTimeline)
            //{
            //something
            //}

            //this was the only original line in this code:
            //return View(db.EventTables.ToList());

            //try changing it to:
            //return View(queryWholeTimeline.ToList());
            return View(queryWholeTimeline);
            //or not lol


        }

        // GET: EventTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTable eventTable = db.EventTables.Find(id);
            if (eventTable == null)
            {
                return HttpNotFound();
            }
            return View(eventTable);
        }

        // GET: EventTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,DateCreated,EventTitle,EventDay,EventMonth,EventYear,PeopleInvolved,EventCaption,UploadMedia")] EventTable eventTable)
        {
            if (ModelState.IsValid)
            {
                db.EventTables.Add(eventTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventTable);
        }

        // GET: EventTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTable eventTable = db.EventTables.Find(id);
            if (eventTable == null)
            {
                return HttpNotFound();
            }
            return View(eventTable);
        }

        // POST: EventTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,DateCreated,EventTitle,EventDay,EventMonth,EventYear,PeopleInvolved,EventCaption,UploadMedia")] EventTable eventTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventTable);
        }

        // GET: EventTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTable eventTable = db.EventTables.Find(id);
            if (eventTable == null)
            {
                return HttpNotFound();
            }
            return View(eventTable);
        }

        // POST: EventTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventTable eventTable = db.EventTables.Find(id);
            db.EventTables.Remove(eventTable);
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
