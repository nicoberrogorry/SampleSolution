using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using UIProcess;
using WebUserInterface.Models.Administration.Shared;
using WebUserInterface.Models.Administration;
using UIProcess.PersonsServiceReference;

namespace WebUserInterface.Controllers
{
    public class AdministrationController : Controller
    {
        private PersonsUIProcess personsUIProcess = new PersonsUIProcess();
        private ProfessionsUIProcess professionsUIProcess = new ProfessionsUIProcess();

        private List<ProfessionSummaryViewModel> LoadProfessionSummaryViewModelList()
        {
            List<ProfessionSummaryViewModel> result = new List<ProfessionSummaryViewModel>();

            var professionsSummary = professionsUIProcess.GetProfessionsSummary();

            foreach (var summary in professionsSummary)
            {
                ProfessionSummaryViewModel professionSummaryViewModel =
                    new ProfessionSummaryViewModel()
                    {
                        ProfessionId = summary.ProfessionId,
                        Description = summary.Description
                    };

                result.Add(professionSummaryViewModel);
            }

            return result;
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            ViewBag.Message = "Register a new person.";


            CreatePersonViewModel createPersonViewModel = new CreatePersonViewModel()
            {
                PersonDetails = new PersonDetailsViewModel(),
                ProfessionsList = LoadProfessionSummaryViewModelList()
            };

            return View(createPersonViewModel);
        }


        [HttpPost]
        public ActionResult CreatePerson(CreatePersonViewModel createPersonViewModel)
        {
            Profession profession = new Profession()
            {
                ProfessionId = createPersonViewModel.PersonDetails.ProfessionSummary.ProfessionId
            };

            Person person = new Person
            {
                Name = createPersonViewModel.PersonDetails.Name,
                LastName = createPersonViewModel.PersonDetails.LastName,
                Profession = profession,
                Address = createPersonViewModel.PersonDetails.Address,
                CellularPhone = createPersonViewModel.PersonDetails.CellularPhone,
                Email = createPersonViewModel.PersonDetails.Email
            };

            personsUIProcess.CreatePerson(person);

            return View("CreatePersonSuccess");
        }

        [HttpGet]
        public ActionResult PersonFinder()
        {
            ViewBag.Message = "Find persons on the database.";

            var personFinderViewModel = new PersonFinderViewModel()
            {
                PersonDetails = new PersonDetailsViewModel(),
                ProfessionsList = LoadProfessionSummaryViewModelList()
            };

            return View(personFinderViewModel);
        }

        [HttpPost]
        public ActionResult PersonFinder(PersonFinderViewModel oldPersonFinderViewModel)
        {
            // Construct a filter and search for persons
            FindPersonsFilter findPersonFilter = new FindPersonsFilter()
            {
                Name = oldPersonFinderViewModel.PersonDetails.Name,
                ProfessionId = oldPersonFinderViewModel.PersonDetails.ProfessionSummary.ProfessionId,
                LastName = oldPersonFinderViewModel.PersonDetails.LastName,
                Address = oldPersonFinderViewModel.PersonDetails.Address,
                CellularPhone = oldPersonFinderViewModel.PersonDetails.CellularPhone,
                Email = oldPersonFinderViewModel.PersonDetails.Email
            };

            List<Person> foundPersons = personsUIProcess.FindPersonsSummary(findPersonFilter);


            // Persist the user input (profession summary and person details)
            ProfessionSummaryViewModel persistedProfessionSummary = new ProfessionSummaryViewModel()
            {
                ProfessionId = oldPersonFinderViewModel.PersonDetails.ProfessionSummary.ProfessionId
            };
            PersonDetailsViewModel persistedPersonDetails = new PersonDetailsViewModel
            {
                PersonId = oldPersonFinderViewModel.PersonDetails.PersonId,
                Name = oldPersonFinderViewModel.PersonDetails.Name,
                ProfessionSummary = persistedProfessionSummary,
                LastName = oldPersonFinderViewModel.PersonDetails.Name,
                Address = oldPersonFinderViewModel.PersonDetails.Address,
                CellularPhone = oldPersonFinderViewModel.PersonDetails.CellularPhone,
                Email = oldPersonFinderViewModel.PersonDetails.Email
            };

            // Create a new person filter to display the results (restore user input and reload professions)
            PersonFinderViewModel personFinderViewModel = new PersonFinderViewModel()
            {
                PersonDetails = persistedPersonDetails,
                ProfessionsList = LoadProfessionSummaryViewModelList(),
                SearchResults = new List<PersonSummaryViewModel>()
            };

            // Fill search result list
            foreach (Person person in foundPersons)
            {
                ProfessionSummaryViewModel professionSummary = new ProfessionSummaryViewModel()
                {
                    Description = person.Profession.Description
                };

                PersonSummaryViewModel personSummary = new PersonSummaryViewModel()
                {
                    PersonId = person.PersonId,
                    Name = person.Name,
                    LastName = person.LastName,
                    ProfessionSummary = professionSummary
                };

                personFinderViewModel.SearchResults.Add(personSummary);
            }

            return View(personFinderViewModel);
        }

        [HttpPost]
        public ActionResult PersonFinderDetails(PersonFinderViewModel personFinderViewModel)
        {

            Person person = personsUIProcess.GetPersonDetails(personFinderViewModel.SelectedPersonId);

            ProfessionSummaryViewModel professionSummary = new ProfessionSummaryViewModel()
            {
                Description = person.Profession.Description
            };

            PersonDetailsViewModel personDetails = new PersonDetailsViewModel()
            {
                Name = person.Name,
                LastName = person.LastName,
                ProfessionSummary = professionSummary,
                CellularPhone = person.CellularPhone,
                Address = person.Address,
                Email = person.Email
            };

            PersonFinderDetailsViewModel personFinderDetailsViewModel = new PersonFinderDetailsViewModel()
            {
                PersonDetails = personDetails
            };

            return View(personFinderDetailsViewModel);
        }
    }
}