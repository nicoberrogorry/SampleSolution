using BusinessEntities;
using System.Collections.Generic;

namespace UIProcess
{
    public class ProfessionsUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            using (var professionsServiceClient = new ProfessionsServiceReference.ProfessionsServiceClient())
            {
                professionsServiceClient.CreateProfession(profession);
            }
        }

        public List<Profession> GetProfessionsSummary()
        {
            List<Profession> result = null;

            using (var professionsServiceClient = new ProfessionsServiceReference.ProfessionsServiceClient())
            {
                professionsServiceClient.GetProfessionsSummary();
            }

            return result;
        }
    }
}
