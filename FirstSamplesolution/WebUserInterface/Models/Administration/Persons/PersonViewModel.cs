using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUserInterface.Models.Administration.Persons
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CellularPhone { get; set; }
        public string Email { get; set; }
        public string ProfessionDescription { get; set; }
        public string Address { get; internal set; }
    }
}