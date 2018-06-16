using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUserInterface.Models;
using WebUserInterface.Models.CreatePerson;
using UserInterfaceLogic;

namespace WebUserInterface.Controllers.Administration
{
    public class PersonsController : Controller
    {
        public ActionResult Index()
        {
            var professionsController = new ProfessionsController();

            var createPersonViewModel = new CreatePersonViewModel{
                ProfessionsList = professionsController.GetProfessionListViewModel(),
                Name = "Your name",
                LastName = "Your last name",
                Address = "Your business address",
                CellularPhone = "Your business cellular phone",
                Email = "Your business email"
            };

            return View("CreatePerson", createPersonViewModel);
        }

        [HttpPost]
        public ActionResult CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            var personsController = new PersonsController();
            personsController.CreatePerson(createPersonViewModel);



            return null;
        }


        public ActionResult Search()
        {
            return View("search");
        }
    }
}