using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    [DataContract]
    public class Profession
    {
        [DataMember]
        public int ProfessionId { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
