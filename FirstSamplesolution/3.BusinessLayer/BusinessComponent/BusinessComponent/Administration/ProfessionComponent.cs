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
            List<Profession> result = null;

            ProfessionDataAccess professionDataAccess = new ProfessionDataAccess();

            result = professionDataAccess.GetProfessions();

            return result;
        }
    }
}
