using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryLabourAllView
    {
        public long SiJcTrnId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public string? ChargeOutRateDescription { get; set; }
        public string? CostRateDescription { get; set; }
        public DateTime? TransDate { get; set; }
        public string? StockItemText { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Commitquantity { get; set; }
        public decimal? Actualquantity { get; set; }
        public decimal? LabRate { get; set; }
        public decimal? UnitValue { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Completed { get; set; }
        public string TransType { get; set; } = null!;
        public long? StockItemId { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? Jobitemtypecode { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public long? SiJcchdId { get; set; }
        public long? CaseId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SioperationId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public double? ExchangeRate { get; set; }
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
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public decimal? UnitSellingPrice { get; set; }
    }
}
