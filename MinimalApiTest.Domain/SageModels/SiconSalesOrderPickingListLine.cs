using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderPickingListLine
    {
        public long SiconSalesOrderPickingListLiId { get; set; }
        public long? SiconSalesOrderLineId { get; set; }
        public string? PickingListNumber { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AllocatedThisTime { get; set; }
        public decimal? DespatchedThisTime { get; set; }
        public decimal? AppliedQuantity { get; set; }
        public decimal? UnitValue { get; set; }
        public DateTime? PrintedDateTime { get; set; }
        public string? PrintedByUserId { get; set; }
    }
}
