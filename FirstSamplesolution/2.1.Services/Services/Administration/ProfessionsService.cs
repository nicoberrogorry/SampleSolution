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
            ProfessionComponent professionComponent = new ProfessionComponent();
            professionComponent.CreateProfession(profession);
        }

        public List<Profession> GetProfessionsSummary()
        {
            List<Profession> result = null;

            var professionComponent = new ProfessionComponent();

            result = professionComponent.GetProfessionsSummary();

            return result;
        }
    }
}
