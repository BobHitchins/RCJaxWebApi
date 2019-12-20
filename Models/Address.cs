namespace RCJaxWebApi.Models
{
    public class Address : BaseModel
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateAbbr { get; set; }
        public string ZipCode { get; set; }

        // Relationships
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
