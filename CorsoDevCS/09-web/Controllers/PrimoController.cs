using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_web.Controllers
{
    public class PrimoController : Controller
    {
        // GET: Primo
        public ActionResult Index()
        {
            ViewBag.Nome = "Andrea";
            ViewBag.Oggetto = new { Nome = "Mario", Cognome = "Rossi" };
            return View();
        }
    }
}