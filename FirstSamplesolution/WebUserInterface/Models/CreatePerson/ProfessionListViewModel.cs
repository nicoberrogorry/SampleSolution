using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUserInterface.Models.CreatePerson
{
    public class ProfessionListViewModel
    {
        public List<ProfessionViewModel> AvailableProfessions { get; set; }

        public int SelectedProfessionIdViewModel { get; set; }
    }
}