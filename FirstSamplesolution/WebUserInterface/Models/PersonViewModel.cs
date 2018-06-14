using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUserInterface.Models
{
    public class PersonViewModel
    {
        public List<Profession> Professions { get; set; }

        public int SelectedProfession { get; set; }
    }

}