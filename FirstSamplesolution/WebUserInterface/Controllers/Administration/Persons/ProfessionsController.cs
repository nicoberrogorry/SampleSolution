using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.Administration.Persons;
using UserInterfaceLogic;

namespace WebUserInterface.Controllers.Administration.Persons
{
    public class ProfessionsController
    {
        public List<Tuple<int, ProfessionViewModel>> GetProfessionsViewList()
        {
            var professions = new List<Tuple<int, ProfessionViewModel>>();
            var professionUIProcess = new ProfessionUIProcess();
            foreach(var profession in professionUIProcess.GetProfessions())
            {
                professions.Add(Tuple.Create(profession.ProfessionId, new ProfessionViewModel{Description = profession.Description}));
            }

            return professions;
        }
    }
}