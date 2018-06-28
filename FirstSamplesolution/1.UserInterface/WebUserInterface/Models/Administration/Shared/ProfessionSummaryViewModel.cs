using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserInterface.Models.Administration.Shared
{
    public class ProfessionSummaryViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int? ProfessionId { get; set; }
                
        public string Description { get; set; }
    }
}