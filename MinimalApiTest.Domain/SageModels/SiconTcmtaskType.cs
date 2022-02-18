using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtaskType
    {
        public long SiconTcmtaskTypeId { get; set; }
        public string TaskTypeName { get; set; } = null!;
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? IsSystem { get; set; }
        public bool? Deleted { get; set; }
    }
}
