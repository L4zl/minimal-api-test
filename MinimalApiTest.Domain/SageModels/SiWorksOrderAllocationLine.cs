using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderAllocationLine
    {
        public long SiWorksOrderAllocationLineId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long? AllocationId { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityIssued { get; set; }
        public decimal? QuantityToIssue { get; set; }
        public decimal? QuantityPicked { get; set; }
        public string? BinName { get; set; }
        public long? BinItemId { get; set; }
        public long WarehouseId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public long? IssueTransactionHistoryId { get; set; }
        public decimal? IssueCost { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public bool? SpareBit1 { get; set; }
        public bool? SpareBit2 { get; set; }
    }
}
