using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlstockItemSupplier
    {
        public long Sisid { get; set; }
        public long PrdHierNodeId { get; set; }
        public string SupplierCode { get; set; } = null!;
        public bool IsPreferred { get; set; }
        public int? LeadTime { get; set; }
        public long? LeadTimeUnit { get; set; }
        public decimal MinimumOrderQuantity { get; set; }
        public decimal UsualOrderQuantity { get; set; }
        public decimal OrderQuantityYtd { get; set; }
        public decimal OrderValueYtd { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public string SupplierStockCode { get; set; } = null!;
        public long LandedCostsTypeId { get; set; }
        public decimal LandedCostsValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? CountryOfOriginId { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
