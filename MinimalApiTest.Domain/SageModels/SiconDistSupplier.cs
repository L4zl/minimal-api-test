using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSupplier
    {
        public long SiconDistSupplierId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public decimal? StockCoverInDays { get; set; }
        public decimal? DefaultLeadTime { get; set; }
        public decimal? SafetyMargin { get; set; }
        public int? LandedCostsTypeId { get; set; }
        public decimal? LandedCostsValue { get; set; }
        public decimal MinOrderValue { get; set; }
    }
}
