using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPoporderReturn
    {
        public long SiconPoporderReturnId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? WaporderId { get; set; }
        public bool Calloff { get; set; }
        public bool Confidential { get; set; }
        public string DocumentNoPrefix { get; set; } = null!;
        public string RequestedBy { get; set; } = null!;
        public string RequestedFor { get; set; } = null!;
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public bool? Deleted { get; set; }
    }
}
