using BusinessEntities;
using Services.Requests;
using Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Services.Administration
{
    [ServiceContract]
    public interface IProfessionsService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json)]
        void CreateProfession(Profession profession);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json)]
        GetProfessionsSummaryResponse GetProfessionsSummary(GetProfessionsSummaryRequest request);
    }
}
