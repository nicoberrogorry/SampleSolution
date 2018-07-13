using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace Services.Administration
{
    [ServiceContract]
    public interface IPersonsService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",RequestFormat = WebMessageFormat.Json)]
        void CreatePerson(Person person);

        [OperationContract]
        [WebInvoke( Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json)]
        List<Person> FindPersonsSummary(FindPersonsFilter findPersonsFilter);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json)]
        Person GetPersonDetails(int personId);
    }
}