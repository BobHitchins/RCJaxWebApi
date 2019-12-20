using System.Collections.Generic;

namespace RCJaxWebApi.Models
{
    public class Member : BaseModel
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string AltEmail { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsTeamLead { get; set; }
        public bool IsAfire { get; set; }
        public bool IsSpiritualDir { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public ICollection<AfireMember> AfireLink { get; set; }  // Many-to-Many
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
