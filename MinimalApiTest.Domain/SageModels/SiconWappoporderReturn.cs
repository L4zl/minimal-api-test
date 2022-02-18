using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWappoporderReturn
    {
        public long SiconWappoporderReturnId { get; set; }
        public long? PoporderReturnId { get; set; }
        public int WaporderId { get; set; }
        public bool CallOff { get; set; }
        public string RequestedBy { get; set; } = null!;
        public string RequestedFor { get; set; } = null!;
        public bool Confidential { get; set; }
        public string DocumentNoPrefix { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
