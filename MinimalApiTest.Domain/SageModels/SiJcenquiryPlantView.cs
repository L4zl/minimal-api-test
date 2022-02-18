﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryPlantView
    {
        public long SiJcTrnId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcEmpId { get; set; }
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
        public string? PlantItem { get; set; }
        public string? PlantDescription { get; set; }
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
        public string JobLevel { get; set; } = null!;
        public string Nlref { get; set; } = null!;
        public string Nlcc { get; set; } = null!;
        public string Nldept { get; set; } = null!;
        public string Nlname { get; set; } = null!;
        public string NlreportType { get; set; } = null!;
        public decimal? UnitSellingPrice { get; set; }
        public int? TimesheetWeekNumber { get; set; }
        public DateTime? TimesheetWeekStart { get; set; }
        public string? TimesheetWeekNote { get; set; }
        public string? TimesheetDayNotes { get; set; }
    }
}
