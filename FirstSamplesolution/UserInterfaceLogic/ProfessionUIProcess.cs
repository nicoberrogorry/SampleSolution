using BusinessEntities;
using BusinessComponent;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessComponent.Administration;

namespace UserInterfaceLogic
{
    class ProfessionUIProcess
    {
        public void CreateProfession(Profession profession)
        {
            var professionComponent = new ProfessionComponent();
            professionComponent.CreateProfession(profession);
        }
    }
}
