using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUserInterface.Models.CreatePerson;

namespace WebUserInterface.Models
{
    public class CreatePersonViewModel
    {
        public ProfessionListViewModel ProfessionsList { get; set; }

        public string Name { get; set; }

        public string CellularPhone { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}