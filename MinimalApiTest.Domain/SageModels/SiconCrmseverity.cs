using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmseverity
    {
        public long SiconCrmseverityId { get; set; }
        public string SeverityName { get; set; } = null!;
        public short SeverityNumber { get; set; }
        public bool IsDefault { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
