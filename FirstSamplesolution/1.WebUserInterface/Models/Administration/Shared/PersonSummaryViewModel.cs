using System.Web.Mvc;

namespace WebUserInterface.Models.Administration.Shared
{
    public class PersonSummaryViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int? PersonId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public ProfessionSummaryViewModel ProfessionSummary { get; set; }
    }
}