using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderAllocationLine
    {
        public long SiconSalesOrderAllocLineId { get; set; }
        public long SiconSalesOrderLineId { get; set; }
        public long AllocationId { get; set; }
        public DateTime? AllocatedDate { get; set; }
        public decimal? AllocatedQuantity { get; set; }
        public decimal? DespatchedQuantity { get; set; }
        public decimal? AppliedForQuantity { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? OrderNumber { get; set; }
        public long? PickingListStatus { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public bool? Completed { get; set; }
    }
}
