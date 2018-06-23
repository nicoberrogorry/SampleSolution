using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess;
using UserInterfaceLogic;
using WebUserInterface.Models;
using WebUserInterface.Models.Administration;

using WebUserInterface.Models.Administration.Persons;

namespace WebUserInterface.Controllers.Administration.Persons
{
    public class PersonsController : Controller
    {
        [Route("Administration/CreatePerson")]
        [Route("Administration/CreatePerson/Index")]
        public ActionResult CreatePersonIndex()
        {
            var professionsController = new ProfessionsController();

            var createPersonViewModel = new CreatePersonViewModel
            {
                AvailableProfessions = professionsController.GetProfessionsViewList(),
                PersonInput = new PersonViewModel
                {
                    Name = "Your name",
                    LastName = "Your last name",
                    Address = "Your business address",
                    CellularPhone = "Your business cellular phone",
                    Email = "Your business email"
                }
            };

            return View("Administration/CreatePerson", createPersonViewModel);
        }

        [HttpPost]
        public ActionResult CreatePersonResult(CreatePersonViewModel createPersonViewModel)
        {
            var personUIProcess = new PersonUIProcess();
            var person = new Person
            {
                Name = createPersonViewModel.PersonInput.Name,
                LastName = createPersonViewModel.PersonInput.LastName,
                ProfessionId = createPersonViewModel.SelectedProfessionId,
                Address = createPersonViewModel.PersonInput.Address,
                CellularPhone = createPersonViewModel.PersonInput.CellularPhone,
                Email = createPersonViewModel.PersonInput.Email
            };

            personUIProcess.CreatePerson(person);

            return View("Administration/CreatePerson", createPersonViewModel); ;
        }

        [Route("Administration/PersonFinder")]
        [Route("Administration/PersonFinder/Index")]
        public ActionResult PersonFinderIndex()
        {
            var personFinderViewModel = new PersonFinderViewModel()
            {
                SearchedPerson = new PersonViewModel
                {
                    Name = "Enter person name",
                    ProfessionDescription = "Enter person profession",
                    LastName = "Enter person last name",
                    Address = "Enter person address",
                    CellularPhone = "Enter person cellular phone number",
                    Email = "Enter person email"
                },
                NameFieldMatched = false,
                ProfessionDescriptionFieldMatched = false,
            };

            return View("Administration/PersonFinder", personFinderViewModel);
        }

        [HttpPost]
        public ActionResult PersonFinderResult(PersonFinderViewModel personFinderViewModel)
        {
            var personUIProcess = new PersonUIProcess();
            

            var searchedPerson = new Person
            {
                Name = personFinderViewModel.SearchedPerson.Name,
                LastName = personFinderViewModel.SearchedPerson.LastName,
                Address = personFinderViewModel.SearchedPerson.Address,
                CellularPhone = personFinderViewModel.SearchedPerson.CellularPhone,
                Email = personFinderViewModel.SearchedPerson.Email
            };

            var professionUIProcess = new ProfessionUIProcess();
            var professionResult = professionUIProcess.FindProfessions(personFinderViewModel.SearchedPerson.ProfessionDescription);

            var matchedPersons = personUIProcess.FindPerson(searchedPerson);
            foreach (var match in matchedPersons)
            {

            }

            return View("Administration/PersonFinder", personFinderViewModel);
        }
    }
}