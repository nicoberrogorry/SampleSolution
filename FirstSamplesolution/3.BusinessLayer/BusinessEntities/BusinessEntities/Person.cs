using System.Runtime.Serialization;

namespace BusinessEntities
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int? PersonId { get; set; }
        [DataMember]
        public Profession Profession { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CellularPhone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}
