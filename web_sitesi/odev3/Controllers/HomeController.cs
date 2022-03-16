using odev3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev3.Controllers
{
    public class HomeController : Controller
    {
        private YorumlarDatabaseEntities db = new YorumlarDatabaseEntities();

        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

        [AllowAnonymous]
        public ActionResult AnaSayfa()
        {
            ViewBag.Title = "Ana Sayfa";
            ViewBag.resimler = db.resim.ToList();
            return View(ViewBag.resimler);
        }

    }
}