using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistRepGroup
    {
        public long SiconDistRepGroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public long? SourceWarehouseId { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
