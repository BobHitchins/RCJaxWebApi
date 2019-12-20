using System.Collections.Generic;

namespace RCJaxWebApi.Models
{
    public class Afire : BaseModel
    {
        public int AfireId { get; set; }
        public string AfireName { get; set; }
        public string AfireDesc { get; set; }

        // Relationships
        public ICollection<AfireMember> MemberLink { get; set; }
    }
}
