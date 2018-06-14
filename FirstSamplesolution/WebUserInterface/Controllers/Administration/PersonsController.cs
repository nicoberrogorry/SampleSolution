using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserInterface.Controllers.Administration
{
    public class PersonsController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View("create");
        }

        public ActionResult Search()
        {
            return View("search");
        }
    }
}