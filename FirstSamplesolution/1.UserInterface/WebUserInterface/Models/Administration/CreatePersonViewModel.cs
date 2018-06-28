using System;
using System.Collections.Generic;
using WebUserInterface.Models.Administration.Shared;



namespace WebUserInterface.Models.Administration
{
    public class CreatePersonViewModel
    {
        public List<ProfessionSummaryViewModel> ProfessionsList { get; set; }

        public PersonDetailsViewModel PersonDetails { get; set; }
    }
}