using BusinessEntities;
using BusinessComponent;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessComponent.Administration;

namespace UserInterfaceLogic
{
    public class ProfessionUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            var professionComponent = new ProfessionComponent();
            professionComponent.CreateProfession(profession);
        }
            
        public List<Profession> GetProfessions()
        {
            //var professionComponent = new ProfessionComponent();
            //var allProfessions = professionComponent.GetProfessions();
            return null;
        }

        public List<Profession> FindProfessions(string professionDescription)
        {
            var professionComponent = new ProfessionComponent();
            var matchedProfessions = professionComponent.FindProfessions(professionDescription);
            return matchedProfessions;
        }
    }
}
