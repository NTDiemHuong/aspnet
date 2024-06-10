using NTDHLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTDHLesson08CF.Controllers
{
    public class NTDHCategoryController : Controller
    {
        private static NTDHBookStore _NTDHBookstore;
        public NTDHCategoryController()
        {
            _NTDHBookstore = new NTDHBookStore();
        }
        // GET: NTDHCategory
        public ActionResult NTDHIndex()
        {
            var NTDHCategory = _NTDHBookstore.NTDHCategories.ToList();
            return View(NTDHCategory);
        }
        [HttpGet]
        public ActionResult NTDHCreate()
        {
            var NTDHCategory = new NTDHCategory();
            return View();
        }
        [HttpPost]
        public ActionResult NTDHCreate(NTDHCategory NTDHCategory)
        {
            _NTDHBookstore.NTDHCategories.Add(NTDHCategory);
            _NTDHBookstore.SaveChanges();
          
            return RedirectToAction("NTDHIndex");
        }
    }
}