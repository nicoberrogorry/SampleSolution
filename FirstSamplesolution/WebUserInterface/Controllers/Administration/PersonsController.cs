using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers.Administration
{
    public class PersonsController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonViewModel model = new PersonViewModel();
            model.Professions = this.GetProfessions();

            return View("create", model);
        }

        [HttpPost]
        public ActionResult Create(PersonViewModel model)
        {
             model = new PersonViewModel();
            model.Professions = this.GetProfessions();

            return View("create", model);
        }
        public ActionResult Search()
        {
            return View("search");
        }

        public List<Profession> GetProfessions()
        {
            List<Profession> result = new List<Profession>()
            {
                 new Profession (){ Description="Profession A", ProfessionId=1 },
                 new Profession (){ Description="Profession B", ProfessionId=2 }
            };

            return result;
        }
    }
}