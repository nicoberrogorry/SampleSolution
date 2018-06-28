using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.Administration.Shared;

namespace WebUserInterface.Models.Administration
{
    public class PersonFinderViewModel
    {
        public List<ProfessionSummaryViewModel> ProfessionsList { get; set; }

        public PersonDetailsViewModel PersonDetails { get; set; }

        public List<PersonSummaryViewModel> SearchResults { get; set; }

        public int SelectedPersonId { get; set; }
    }
}