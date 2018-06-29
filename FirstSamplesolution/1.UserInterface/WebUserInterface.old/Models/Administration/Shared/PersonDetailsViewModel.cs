using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserInterface.Models.Administration.Shared
{
    public class PersonDetailsViewModel : PersonSummaryViewModel
    {
        public string CellularPhone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}