using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Services.Administration
{
    [ServiceContract]
    public interface IPersonsService
    {
        [OperationContract]
        void CreatePerson(Person person);

        [OperationContract]
        List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter);
    }
}