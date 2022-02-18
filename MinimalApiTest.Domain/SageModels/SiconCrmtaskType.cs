using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmtaskType
    {
        public long SiconCrmtaskTypeId { get; set; }
        public string TaskTypeName { get; set; } = null!;
        public bool IsDefault { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public long? SiconCrmtaskLinkTypeId { get; set; }
        public long? ForeignTypeId { get; set; }
        public bool IsSystem { get; set; }
        public short TaskTypeNumber { get; set; }
    }
}
