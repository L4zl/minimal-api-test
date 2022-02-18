using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderLineIssueTransView
    {
        public long? SiWorksOrderId { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public long? LineTypeId { get; set; }
        public int HasChildren { get; set; }
        public string? Wonumber { get; set; }
        public string? Woname { get; set; }
        public long? Sijcjobid { get; set; }
        public long TransactionHistoryId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionTypeName { get; set; } = null!;
        public string TransactionGroupName { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal? CostValue { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public string BinName { get; set; } = null!;
    }
}
