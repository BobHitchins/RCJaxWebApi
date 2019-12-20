using System;

namespace RCJaxWebApi.Models
{
    public class Content : BaseModel
    {
        public int ContentId { get; set; }
        public string ContentText { get; set; }
        public string ContentLink { get; set; }
        public DateTime ContentDatetime { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public int ContentTypeId { get; set; }
        public ContentType ContentType { get; set; }
    }
}
