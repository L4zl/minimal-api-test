using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitSopsView
    {
        public long SoporderReturnId { get; set; }
        public string No { get; set; } = null!;
        public string Type { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public string DocumentStatus { get; set; } = null!;
        public int? PartAllocatedKits { get; set; }
        public int? FullyAllocatedKits { get; set; }
        public int? UnAllocatedKits { get; set; }
        public string? SopallocationStatus { get; set; }
        public string KitAllocationStatus { get; set; } = null!;
    }
}
