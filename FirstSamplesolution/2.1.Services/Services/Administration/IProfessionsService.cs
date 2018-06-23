using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Services.Administration
{
    [ServiceContract]
    public interface IProfessionsService
    {
        [OperationContract]
        void CreateProfession(Profession profession);

        [OperationContract]
        List<Profession> FindProfessions(string professionDescription);
    }
}
