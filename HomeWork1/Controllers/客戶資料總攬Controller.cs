using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeWork1.Models;

namespace HomeWork1.Controllers
{
    public class 客戶資料總攬Controller : Controller
    {
        private Entities db = new Entities();

        // GET: 客戶資料總攬
        [Authorize]
        public ActionResult Index()
        {
            return View(db.客戶資料總攬.ToList());
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
