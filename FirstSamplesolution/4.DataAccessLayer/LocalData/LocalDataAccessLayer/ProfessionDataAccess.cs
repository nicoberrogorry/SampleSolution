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
            List<Profession> result = new List<Profession>();
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

                        result.Add(profession);
                    }
                }
            }
            return result;
        }
    }
}
