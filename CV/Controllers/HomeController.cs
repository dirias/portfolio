using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Studies()
        {
            ViewBag.Message = "Estudios llevados.";

            return View();
        }
        public ActionResult Proyects()
        {
            ViewBag.Message = "Proyectos realizados.";

            return View();
        }

        public ActionResult Experience()
        {
            ViewBag.Message = "Experiencia laboral.";

            return View();
        }
    }
}