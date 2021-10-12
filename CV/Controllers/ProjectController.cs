using CV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index(Project project)
        {
            List<Project> listaProjectos = project.GetProjects();
            return View(listaProjectos);
        }
    }
}