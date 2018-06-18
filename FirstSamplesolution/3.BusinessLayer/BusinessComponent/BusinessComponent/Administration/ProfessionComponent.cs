using BusinessEntities;
using LocalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponent.Administration
{
    public class ProfessionComponent
    {
        public void CreateProfession(Profession profession)
        {
            ProfessionDataAccess professionDataAccess = new ProfessionDataAccess();
            professionDataAccess.CreateProfession(profession);
        }

        public List<Profession> GetProfessions()
        {
            List<Profession> allProfessions = null;

            var professionDataAccess = new ProfessionDataAccess();

            allProfessions = professionDataAccess.GetProfessions();

            return allProfessions;
        }

        public List<Profession> FindProfessions(string professionDescription)
        {
            var professionsDataAccess = new ProfessionDataAccess();
            var matchedProfessions = professionsDataAccess.FindProfession(professionDescription);
            return matchedProfessions;
        }
    }
}
