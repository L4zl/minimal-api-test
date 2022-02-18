using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPolineLandedCost
    {
        public long SiconDistPolineLandedCostId { get; set; }
        public long? SiconDistPolandedCostId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? WarehouseId { get; set; }
        public decimal? ProvLandedCostEach { get; set; }
        public decimal? ProvLandedCostTotal { get; set; }
        public decimal? ActualLandedCostEach { get; set; }
        public decimal? ActualLandedCostTotal { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiDistLandedCostTemplateId { get; set; }
    }
}
