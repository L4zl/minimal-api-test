using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryAllByInvoiceView
    {
        public long SiJcTrnId { get; set; }
        public long? TransId { get; set; }
        public string EnquiryType { get; set; } = null!;
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public string TransType { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public string? StockItemText { get; set; }
        public decimal? UnitValue { get; set; }
        public int PlsupplierAccountId { get; set; }
        public int PlpostedSupplierTranId { get; set; }
        public string? StockType { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public decimal? LabRate { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public string? Completed { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int PoporderReturnLineId { get; set; }
        public string PopitemDescription { get; set; } = null!;
        public string PopitemCode { get; set; } = null!;
        public long? SoporderReturnLineId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? SopitemCode { get; set; }
        public string? SopitemDescription { get; set; }
        public long? SiJcchdId { get; set; }
        public long? CaseId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SioperationId { get; set; }
        public long? SiJcVariationId { get; set; }
        public string? DocumentReference { get; set; }
        public long Urn { get; set; }
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
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public string RateDescription { get; set; } = null!;
        public double? ExchangeRate { get; set; }
        public decimal? DocumentExchangeRate { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public string JobLevel { get; set; } = null!;
    }
}
