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

    }
}
