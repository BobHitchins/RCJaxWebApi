using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCJaxWebApi.Models
{
    public class AfireMember
    {
        public int AfireId { get; set; }
        public int MemberId { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public Afire Afire { get; set; }
        public Member Member { get; set; }
    }
}
