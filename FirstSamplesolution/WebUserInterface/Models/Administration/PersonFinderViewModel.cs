using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.Administration.Persons;

namespace WebUserInterface.Models.Administration
{
    public class PersonFinderViewModel
    {
        public PersonViewModel SearchedPerson { get; set; }

        public bool SearchDone { get; set; }

        public bool NameFieldMatched { get; set; }
        public bool ProfessionDescriptionFieldMatched { get; set; }
        public bool LastNameFieldMatched { get; set; }
        public bool AddressFieldMatched { get; set; }
        public bool CellularPhoneFieldMatched { get; set; }
        public bool EmailFieldMatched { get; set; }

        public List<PersonViewModel> Matches { get; set; }
    }
}