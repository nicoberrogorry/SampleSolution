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
            var personUIProcess = new PersonUIProcess();
            var person = new Person
            {
                Name = createPersonViewModel.Name,
                LastName = createPersonViewModel.LastName,
                ProfessionId = createPersonViewModel.ProfessionsList.SelectedProfessionIdViewModel,
                Address = createPersonViewModel.Address,
                CellularPhone = createPersonViewModel.CellularPhone,
                Email = createPersonViewModel.Email
            };

            personUIProcess.CreatePerson(person);

            return View("CreatePerson", createPersonViewModel); ;
        }


        public ActionResult Search()
        {
            return View("search");
        }
    }
}