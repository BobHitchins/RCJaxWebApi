using System.Collections.Generic;

namespace RCJaxWebApi.Models
{
    public class ContentType : BaseModel
    {
        public int ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public string ContentTypeDesc { get; set; }

        // Relationships
        public ICollection<Content> Contents { get; set; }
    }
}
