using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.CreatePerson;
using UserInterfaceLogic;

namespace WebUserInterface.Controllers.Administration
{
    public class ProfessionsController
    {
        public ProfessionListViewModel GetProfessionListViewModel()
        {
            ProfessionListViewModel professionListViewModel = new ProfessionListViewModel();
            professionListViewModel.AvailableProfessions = new List<ProfessionViewModel>();

            var professionUIProcess = new ProfessionUIProcess();
            foreach(var profession in professionUIProcess.GetProfessions())
            {
                professionListViewModel.AvailableProfessions.Add(
                    new ProfessionViewModel
                    {
                        ProfessionId = profession.ProfessionId,
                        Description = profession.Description                       
                    }
                );
            }

            professionListViewModel.SelectedProfessionIdViewModel =
                professionListViewModel.AvailableProfessions.First().ProfessionId;
            

            return professionListViewModel;
        }
    }
}