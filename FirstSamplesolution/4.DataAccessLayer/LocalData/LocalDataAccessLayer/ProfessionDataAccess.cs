using BusinessEntities;
using LocalDataAccessLayer.Models;
using System.Collections.Generic;

namespace LocalDataAccessLayer
{
    public class ProfessionDataAccess
    {
        public void CreateProfession(Profession p)
        {
            using (var dataContext = new ProfessionsDataContext())
            {
                dataContext.CreateProfession(p.Description);
            }
        }

        public List<Profession> GetAllProfessionsSummary()
        {
            List<Profession> result = new List<Profession>();

            using (var professionsDataContext = new ProfessionsDataContext())
            {
                using (var professionsSummarise = professionsDataContext.GetAllProfessionsSummary())
                {
                    foreach (var professionSummary in professionsSummarise)
                    {
                        Profession profession = new Profession()
                        {
                            ProfessionId = professionSummary.ProfessionId,
                            Description = professionSummary.Description
                        };

                        result.Add(profession);
                    }
                }
            }

            return result;
        }
    }
}