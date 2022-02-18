using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquirySopinvoiceView
    {
        public long? Id { get; set; }
        public long Sijctrnid { get; set; }
        public long? Sijcjobid { get; set; }
        public string? JobNumber { get; set; }
        public long? Sijcchdid { get; set; }
        public string? Costcode { get; set; }
        public string? HeaderDescription { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? DocumentNo { get; set; }
        public string? ItemDescription { get; set; }
        public string? CustomerRef { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Unitvalue { get; set; }
        public decimal? TotalSovalue { get; set; }
        public decimal? RemainingCommitment { get; set; }
        public short? SoplineCount { get; set; }
        public long? DocumentCount { get; set; }
        public string DocumentType { get; set; } = null!;
        public string? DocumentReference { get; set; }
        public string? SecondReference { get; set; }
        public decimal? DocumentValue { get; set; }
        public string AllocationStatus { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public long? Urn { get; set; }
        public decimal? Trntotal { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
