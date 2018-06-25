using System.Collections.Generic;
using UIProcess.ProfessionsServiceReference;

namespace UIProcess
{
    public class ProfessionsUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            using (var professionsServiceClient = new ProfessionsServiceReference.ProfessionsServiceClient("BasicHttpBinding_IProfessionsService"))
            {
                CreateProfessionRequest request = new CreateProfessionRequest()
                {
                    profession = profession
                };

                professionsServiceClient.CreateProfession(request);
            }
        }

        public List<Profession> GetProfessionsSummary()
        {
            List<Profession> result = null;

            using (var professionsServiceClient = new ProfessionsServiceReference.ProfessionsServiceClient("BasicHttpBinding_IProfessionsService"))
            {
                professionsServiceClient.GetProfessionsSummary(new GetProfessionsSummaryRequest());
            }

            return result;
        }
    }
}
