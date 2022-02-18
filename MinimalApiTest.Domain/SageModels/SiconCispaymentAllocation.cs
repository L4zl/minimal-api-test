using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCispaymentAllocation
    {
        public long SiconCispaymentAllocationId { get; set; }
        public long? ParentId { get; set; }
        public long? ParentUrn { get; set; }
        public decimal? ParentValue { get; set; }
        public long? ChildId { get; set; }
        public long? ChildUrn { get; set; }
        public decimal? ChildValue { get; set; }
        public decimal? AllocatedValue { get; set; }
        public decimal? LabourPercent { get; set; }
        public decimal? LabourValue { get; set; }
        public decimal? MaterialPercent { get; set; }
        public decimal? MaterialValue { get; set; }
        public decimal? OtherPercent { get; set; }
        public decimal? OtherValue { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
