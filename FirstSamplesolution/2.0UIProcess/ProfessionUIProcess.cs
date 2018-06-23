using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

using UIProcess.ProfessionsServiceReference;

namespace UserInterfaceLogic
{
    public class ProfessionUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            ProfessionsServiceClient client = new ProfessionsServiceClient("BasicHttpBinding_IProfessionsService");

            CreateProfessionRequest request = new CreateProfessionRequest()
            {
                 profession= profession
            };

            client.CreateProfession(request);
        }
            
        public List<Profession> FindProfessions(string professionDescription)
        {
            ProfessionsServiceClient client = new ProfessionsServiceClient("BasicHttpBinding_IProfessionsService");

            //    var professionComponent = new ProfessionComponent();
            //    var matchedProfessions = professionComponent.FindProfessions(professionDescription);
            FindProfessionsRequest request = new FindProfessionsRequest()
            {
                 professionDescription= professionDescription
            };

            FindProfessionsResponse response= client.FindProfessions(request);

            return response.FindProfessionsResult;
        }
    }
}
