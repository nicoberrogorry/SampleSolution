using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Services.Responses
{
    [DataContract]
    public class GetProfessionsSummaryResponse
    {
        [DataMember]
        public List<Profession> Professions { get; set; }
    }

}