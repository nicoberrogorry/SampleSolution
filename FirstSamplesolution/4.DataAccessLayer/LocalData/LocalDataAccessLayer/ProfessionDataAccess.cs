using BusinessEntities;
using LocalDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Profession> GetProfessions()
        {
            List<Profession> allProfessions = new List<Profession>();
            Profession profession = null;

            using (var dataContext = new ProfessionsDataContext())
            {
                using (var linqResult = dataContext.GetProfession())
                {
                    foreach (var row in linqResult)
                    {
                        profession = new Profession()
                        {
                            ProfessionId = row.ProfessionId,
                            Description = row.Description
                        };

                        allProfessions.Add(profession);
                    }
                }
            }
            return allProfessions;
        }

        public List<Profession> FindProfession(string descriptionFragment)
        {
            var matchedProfessions = new List<Profession>();

            using (var professionsDataContext = new ProfessionsDataContext())
            {
                var matchedProfessionsResult = professionsDataContext.FindProfession(descriptionFragment);
                foreach(var matchResult in matchedProfessionsResult)
                {
                    matchedProfessions.Add(new Profession
                    {
                        ProfessionId = matchResult.ProfessionId,
                        Description = matchResult.Description
                    });
                }
            }

            return matchedProfessions;
        }
    }
}