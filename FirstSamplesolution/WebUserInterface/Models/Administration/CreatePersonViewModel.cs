using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.Administration.Persons;

namespace WebUserInterface.Models.Administration
{
    public class CreatePersonViewModel
    {
        public List<Tuple<int, ProfessionViewModel>> AvailableProfessions { get; set; }

        public int SelectedProfessionId { get; set; }

        public PersonViewModel PersonInput { get; set; }
    }
}