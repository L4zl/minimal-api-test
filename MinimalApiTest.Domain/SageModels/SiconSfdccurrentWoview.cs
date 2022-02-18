using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSfdccurrentWoview
    {
        public long SiWorksOrderId { get; set; }
        public string? Wonumber { get; set; }
        public string? Woname { get; set; }
        public string? Wostatus { get; set; }
        public DateTime? WodueDate { get; set; }
        public decimal? Woquantity { get; set; }
        public decimal? TotalOperationCount { get; set; }
        public decimal? CompletedOperationCount { get; set; }
        public decimal? EstimatedSeconds { get; set; }
        public int? ActualSeconds { get; set; }
        public string? OperationsCompletedCount { get; set; }
        public decimal? OperationsCompletePercent { get; set; }
        public string? Customer { get; set; }
        public string? SalesOrderNo { get; set; }
        public string? FinishedItem { get; set; }
        public decimal? FinishedItemQuantity { get; set; }
        public decimal? FinishedItemBooked { get; set; }
    }
}
