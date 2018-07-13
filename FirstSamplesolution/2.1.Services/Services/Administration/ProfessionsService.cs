using BusinessComponent.Administration;
using BusinessEntities;
using Services.Administration;
using Services.Requests;
using Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Services.Administration
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ProfessionsService : IProfessionsService
    {
        public void CreateProfession(Profession profession)
        {
            ProfessionComponent professionComponent = new ProfessionComponent();
            professionComponent.CreateProfession(profession);
        }

        public GetProfessionsSummaryResponse GetProfessionsSummary(GetProfessionsSummaryRequest request)
        {
            GetProfessionsSummaryResponse result = new GetProfessionsSummaryResponse();         

            var professionComponent = new ProfessionComponent();

            result.Professions = professionComponent.GetProfessionsSummary();

            return result;
        }
    }
}
