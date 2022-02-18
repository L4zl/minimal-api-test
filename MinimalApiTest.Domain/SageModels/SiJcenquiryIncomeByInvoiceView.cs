using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryIncomeByInvoiceView
    {
        public long SiJcTrnId { get; set; }
        public long? TransId { get; set; }
        public string TransType { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public long? Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public long? Sijcchdid { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? StockItemText { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? UnitValue { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? DocumentReference { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? SoporderNumber { get; set; }
        public DateTime? SopdocumentDate { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long? Slurn { get; set; }
        public string? SlinvoiceReference { get; set; }
        public string? StockType { get; set; }
        public long? SopdocumentType { get; set; }
        public decimal? LabRate { get; set; }
        public string? InvoiceCreditNumber { get; set; }
        public string? SopitemCode { get; set; }
        public string? SopitemDescription { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public string? Completed { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public DateTime? InvoiceCreditDate { get; set; }
        public string? SopinvoiceCreditNo { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public long? CaseId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SioperationId { get; set; }
        public string AllocationStatus { get; set; } = null!;
        public decimal? ExchangeRate { get; set; }
        public decimal? TranExchangeRate { get; set; }
        public decimal? DocumentExchangeRate { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public DateTime? SpareDate4 { get; set; }
        public DateTime? SpareDate5 { get; set; }
        public string JobLevel { get; set; } = null!;
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public decimal? UnitSellingPrice { get; set; }
    }
}
