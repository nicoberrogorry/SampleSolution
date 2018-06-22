using BusinessComponent.Administration;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Administration
{
    public class ProfessionsService : IProfessionsService
    {
        public List<Profession> GetProfessions()
        {
            var professionComponent = new ProfessionComponent();
            var allProfessions = professionComponent.GetProfessions();
            return allProfessions;
        }
    }
}