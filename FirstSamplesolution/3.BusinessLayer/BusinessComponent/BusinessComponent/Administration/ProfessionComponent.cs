using BusinessEntities;
using LocalDataAccessLayer;
using System.Collections.Generic;

namespace BusinessComponent.Administration
{
    public class ProfessionComponent
    {
        public void CreateProfession(Profession profession)
        {
            ProfessionDataAccess professionDataAccess = new ProfessionDataAccess();
            professionDataAccess.CreateProfession(profession);
        }

        public List<Profession> GetProfessionsSummary()
        {
            List<Profession> result = null;

            var professionDataAccess = new ProfessionDataAccess();

            result = professionDataAccess.GetAllProfessionsSummary();

            return result;
        }
    }
}
