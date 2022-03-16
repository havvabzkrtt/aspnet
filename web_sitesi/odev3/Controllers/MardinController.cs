using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev3.Controllers
{
    public class MardinController : Controller
    {
        [AllowAnonymous]
        // GET: Mardin
        public ActionResult Mardin_Genel()
        {
            ViewBag.Title = "Mardin Hakkında Genel Bilgi";
            return View();
        }

        [AllowAnonymous]
        // GET: Mardin
        public ActionResult Mardin_Tarihi()
        {
            ViewBag.Title = "Mardin'in Tarihi";
            return View();
        }

        [AllowAnonymous]
        // GET: Mardin
        public ActionResult Mardin_GezilecekYerler()
        {
            ViewBag.Title = "Mardin Gezilecek Yerler";
            return View();
        }

        [AllowAnonymous]
        // GET: Mardin
        public ActionResult Mardin_YöreyeÖzgüYemekler()
        {
            ViewBag.Title = "Mardin Yöresine Özgü Yemekler";
            return View();
        }
    }
}