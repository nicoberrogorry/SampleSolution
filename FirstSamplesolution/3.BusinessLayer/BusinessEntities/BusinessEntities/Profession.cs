using System.Runtime.Serialization;

namespace BusinessEntities
{
    [DataContract]
    public class Profession
    {
        [DataMember(EmitDefaultValue = false)]
        public int? ProfessionId { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
