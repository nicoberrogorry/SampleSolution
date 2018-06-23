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
        public void CreateProfession(Profession profession)
        {
            var professionComponent = new ProfessionComponent();
            professionComponent.CreateProfession(profession);
        }

        public List<Profession> FindProfessions(string professionDescription)
        {
            var professionComponent = new ProfessionComponent();

            var matchedProfessions = professionComponent.FindProfessions(professionDescription);

            return matchedProfessions;
        }
    }
}
