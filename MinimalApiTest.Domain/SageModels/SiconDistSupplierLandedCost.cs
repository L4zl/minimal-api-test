using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSupplierLandedCost
    {
        public long SiconDistSupplierLandedCostId { get; set; }
        public long? SupplierId { get; set; }
        public bool LandedCostApplicable { get; set; }
        public string? LandedCost { get; set; }
        public decimal? LandedCostValue { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
