using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NTDHBaiKiemTraGK.Models;

namespace NTDHBaiKiemTraGK.Controllers
{
    public class NTDHKhoaController : Controller
    {
        private NTDHCNTT2Lesson07DbEntities db = new NTDHCNTT2Lesson07DbEntities();

        // GET: NTDHKhoa
        public ActionResult Index()
        {
            return View(db.NTDHKhoa.ToList());
        }

        // GET: NTDHKhoa/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTDHKhoa NTDHKhoa = db.NTDHKhoa.Find(id);
            if (NTDHKhoa == null)
            {
                return HttpNotFound();
            }
            return View(NTDHKhoa);
        }

        // GET: NTDHKhoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NTDHKhoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NTDHMaKH,NTDHtenKH,NTDHTrangThai")] NTDHKhoa NTDHKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NTDHKhoa.Add(NTDHKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(NTDHKhoa);
        }

        // GET: NTDHKhoa/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTDHKhoa NTDHKhoa = db.NTDHKhoa.Find(id);
            if (NTDHKhoa == null)
            {
                return HttpNotFound();
            }
            return View(NTDHKhoa);
        }

        // POST: NTDHKhoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NTDHMaKH,NTDHtenKH,NTDHTrangThai")] NTDHKhoa NTDHKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(NTDHKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(NTDHKhoa);
        }

        // GET: NTDHKhoa/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTDHKhoa NTDHKhoa = db.NTDHKhoa.Find(id);
            if (NTDHKhoa == null)
            {
                return HttpNotFound();
            }
            return View(NTDHKhoa);
        }

        // POST: NTDHKhoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NTDHKhoa NTDHKhoa = db.NTDHKhoa.Find(id);
            db.NTDHKhoa.Remove(NTDHKhoa);
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
