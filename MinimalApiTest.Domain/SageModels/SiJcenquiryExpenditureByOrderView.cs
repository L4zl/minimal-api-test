using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryExpenditureByOrderView
    {
        public long Sijctrnid { get; set; }
        public long? Transid { get; set; }
        public string Transtype { get; set; } = null!;
        public DateTime? Transdate { get; set; }
        public string? Costcode { get; set; }
        public string? HeaderType { get; set; }
        public string? Stockitemtext { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? Unitvalue { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public bool? SelfBilled { get; set; }
        public DateTime? SelfBilledDate { get; set; }
        public string? SelfBilledInvoiceNo { get; set; }
        public long? SelfBilledUrn { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierAccountName { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public DateTime? PopdocumentDate { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? Plurn { get; set; }
        public string? PlinvoiceReference { get; set; }
        public string? Stocktype { get; set; }
        public long? Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public long? PopdocumentType { get; set; }
        public decimal? Labrate { get; set; }
        public string? InvoiceCreditNumber { get; set; }
        public string? PopinvoiceCreditNo { get; set; }
        public string? PopitemCode { get; set; }
        public string? PopitemDescription { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public string? Completed { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public long? Sijcchdid { get; set; }
        public long? CaseId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SioperationId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public decimal ActualInvoicedValue { get; set; }
        public int InvoiceVariance { get; set; }
        public DateTime? InvoiceCreditDate { get; set; }
        public string? PoporderNumber { get; set; }
        public string? DocumentReference { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? TranExchangeRate { get; set; }
        public decimal? DocumentExchangeRate { get; set; }
        public string QueryCode { get; set; } = null!;
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
        public int IsHiredInPlant { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public decimal? UnitSellingPrice { get; set; }
    }
}
