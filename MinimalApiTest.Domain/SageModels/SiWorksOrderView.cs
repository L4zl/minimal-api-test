using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderView
    {
        public long? SiWorksOrderLineId { get; set; }
        public long SiWorksOrderId { get; set; }
        public string? Wonumber { get; set; }
        public string? Woname { get; set; }
        public string? Wostatus { get; set; }
        public long? WostatusEnumId { get; set; }
        public long? Sijcjobid { get; set; }
        public decimal? OriginalEstimateCost { get; set; }
        public decimal? Wocost { get; set; }
        public DateTime? WocreatedDate { get; set; }
        public DateTime? WodueDate { get; set; }
        public decimal? Woquantity { get; set; }
        public long? ParentWoid { get; set; }
        public string? ParentWonumber { get; set; }
        public long? ChildWoid { get; set; }
        public string? ChildWonumber { get; set; }
        public long? SiWorksOrderFinishedItemId { get; set; }
        public long? FinStockItemId { get; set; }
        public string? FinStockCode { get; set; }
        public string? FinItemName { get; set; }
        public decimal? FinQty { get; set; }
        public decimal? FinQtyBooked { get; set; }
        public decimal? FinCost { get; set; }
        public decimal? FinQtyScrapped { get; set; }
        public string FinStatus { get; set; } = null!;
        public long? WolineTypeId { get; set; }
        public long? WolineItemId { get; set; }
        public string? WolineItemCode { get; set; }
        public string? WolineItemName { get; set; }
        public decimal? WolineQty { get; set; }
        public decimal? WolineAllocatedQty { get; set; }
        public decimal? WolineIssuedQty { get; set; }
        public decimal? WolineBudgetCost { get; set; }
        public decimal? WolineEstimateCost { get; set; }
        public decimal? WolineIssuedCost { get; set; }
        public string? OperationPhase { get; set; }
        public string? OperationReference { get; set; }
        public string WolineStatus { get; set; } = null!;
        public long? SiOperationId { get; set; }
        public string? Opnumber { get; set; }
        public string? Opname { get; set; }
        public DateTime? OpstartDate { get; set; }
        public DateTime? OpdueDate { get; set; }
    }
}
