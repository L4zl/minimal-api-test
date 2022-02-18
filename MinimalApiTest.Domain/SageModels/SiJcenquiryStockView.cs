using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryStockView
    {
        public long SiJcTrnId { get; set; }
        public string? StockType { get; set; }
        public string? StockItemCode { get; set; }
        public string? StockItemName { get; set; }
        public DateTime? TransDate { get; set; }
        public string? CostCode { get; set; }
        public string? HeaderType { get; set; }
        public string? Jobitemtypecode { get; set; }
        public string ProjectGroup { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public string? Completed { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? UnitValue { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? BilledInvoiceNo { get; set; }
        public long? BilledUrn { get; set; }
        public string? InvoiceCreditNumber { get; set; }
        public DateTime? InvoiceCreditDate { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public string TransType { get; set; } = null!;
        public bool? DisplayNoCosts { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public long? StockItemId { get; set; }
        public string? StockItemText { get; set; }
        public long? SiJcchdId { get; set; }
        public long? CaseId { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public string? SecondReference { get; set; }
        public string? UserName { get; set; }
        public string? WarehouseName { get; set; }
        public string? BinName { get; set; }
        public string? Reference { get; set; }
        public long? SioperationId { get; set; }
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
        public string? OrderNumber { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
    }
}
