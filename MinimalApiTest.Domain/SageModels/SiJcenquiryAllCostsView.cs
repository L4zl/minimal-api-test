using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryAllCostsView
    {
        public long SiJcTrnId { get; set; }
        public long? TransId { get; set; }
        public string EnquiryType { get; set; } = null!;
        public decimal? CommitQuantity { get; set; }
        public decimal? CommitValue { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? OrderActualValue { get; set; }
        public decimal? ActualValue { get; set; }
        public decimal? InvoiceVariance { get; set; }
        public string TransType { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? Jobitemtypecode { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public string? StockItemText { get; set; }
        public decimal? UnitValue { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public string? StockType { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public decimal? LabRate { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public decimal? TotalSellingPrice { get; set; }
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
        public long? PoporderReturnLineId { get; set; }
        public string? PopitemDescription { get; set; }
        public string PopitemCode { get; set; } = null!;
        public long? SoporderReturnLineId { get; set; }
        public int SoporderReturnId { get; set; }
        public string? OrderNumber { get; set; }
        public string SopitemCode { get; set; } = null!;
        public string SopitemDescription { get; set; } = null!;
        public long? SiJcchdId { get; set; }
        public long? CaseId { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? SupplierAccountName { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public string? PhaseDescription { get; set; }
        public string? StageDescription { get; set; }
        public string? SubStageDescription { get; set; }
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
        public bool? SelfBilled { get; set; }
        public DateTime? SelfBilledDate { get; set; }
        public string? SelfBilledInvoiceNo { get; set; }
        public long? SelfBilledUrn { get; set; }
        public string? RateDescription { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? DocumentExchangeRate { get; set; }
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public string JobLevel { get; set; } = null!;
    }
}
