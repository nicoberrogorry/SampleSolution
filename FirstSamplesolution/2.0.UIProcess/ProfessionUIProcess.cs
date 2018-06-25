using System.Collections.Generic;
using UIProcess.ProfessionsServiceReference;

namespace UIProcess
{
    public class ProfessionsUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            using (var professionsServiceClient = new ProfessionsServiceClient())
            {
                professionsServiceClient.CreateProfession(profession);
            }
        }

        public List<Profession> GetProfessionsSummary()
        {
            List<Profession> result = new List<Profession>();

            using (var professionsServiceClient = new ProfessionsServiceClient())
            {
                Profession[] professions = professionsServiceClient.GetProfessionsSummary();

                result.AddRange(result);
            }

            return result;
        }
    }
}
