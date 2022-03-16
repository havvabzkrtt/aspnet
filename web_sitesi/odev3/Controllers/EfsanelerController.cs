using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev3.Controllers
{
    public class EfsanelerController : Controller
    {
        [AllowAnonymous]
        // GET: Efsaneler
        public ActionResult Mardin_Efsane()
        {
            ViewBag.Title = "Mardin ile İlgili Efsane";
            return View();
        }
    }
}