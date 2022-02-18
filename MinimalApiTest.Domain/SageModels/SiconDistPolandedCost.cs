using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPolandedCost
    {
        public long SiconDistPolandedCostId { get; set; }
        public long? PoporderReturnId { get; set; }
        public string? Name { get; set; }
        public string? ApportionedBy { get; set; }
        public decimal? TotalProvisional { get; set; }
        public decimal? TotalActual { get; set; }
        public decimal? TotalActualInBase { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? ApportionedValue { get; set; }
        public long WarehouseId { get; set; }
        public long? SiDistLandedCostTemplateId { get; set; }
    }
}
