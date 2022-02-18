using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquirySubLineDetailView
    {
        public long SiJcTrnId { get; set; }
        public string EnquiryType { get; set; } = null!;
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcchdId { get; set; }
        public string? CostCode { get; set; }
        public string? ProjectHeaderTypeCode { get; set; }
        public string JobLevel { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public string TransType { get; set; } = null!;
        public long? OrderReturnLineId { get; set; }
        public long? OrderReturnId { get; set; }
        public string? OrderDocumentNo { get; set; }
        public DateTime? OrderDocumentDate { get; set; }
        public string? StockItemText { get; set; }
        public string StockItemCode { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? CommitValue { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? OrderActualValue { get; set; }
        public decimal? ActualValue { get; set; }
        public decimal? InvoiceVariance { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public string? TradingAccountNumber { get; set; }
        public string? TradingAccountName { get; set; }
        public long? TradingAccountId { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public long? CaseId { get; set; }
        public long? TransId { get; set; }
        public string? StockType { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SioperationId { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public long? Urn { get; set; }
        public string? QueryCode { get; set; }
        public DateTime? DocumentDueDate { get; set; }
        public string AllocationStatus { get; set; } = null!;
        public string? DocumentReference { get; set; }
        public decimal? TranExchangeRate { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
    }
}
