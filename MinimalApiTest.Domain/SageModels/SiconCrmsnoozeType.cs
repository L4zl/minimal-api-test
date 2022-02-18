using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmsnoozeType
    {
        public long SiconCrmsnoozeTypeId { get; set; }
        public short SnoozeTypeNumber { get; set; }
        public string SnoozeTypeDescription { get; set; } = null!;
        public short Days { get; set; }
        public short Hours { get; set; }
        public short Minutes { get; set; }
        public bool IsSystem { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
