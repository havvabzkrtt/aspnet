using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev3.Controllers
{
    public class HaberlerController : Controller
    {
        [Authorize]
        // GET: Haberler
        public ActionResult Haber1()
        {
            ViewBag.Title = "Mardin Taş Evler";
            return View();
        }
    }
}