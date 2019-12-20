namespace RCJaxWebApi.Models
{
    public class Phone : BaseModel
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }

        // Relationships
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
