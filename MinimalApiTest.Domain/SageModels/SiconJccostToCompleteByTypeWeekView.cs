using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJccostToCompleteByTypeWeekView
    {
        public long SiJcJobId { get; set; }
        public string? RevisedBudgetType { get; set; }
        public DateTime? DateLink { get; set; }
        public int? Period { get; set; }
        public int? PeriodYear { get; set; }
        public long? SysAccountingPeriodId { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }
        public decimal Pccomplete { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Labour { get; set; }
        public decimal? Material { get; set; }
        public decimal? Plant { get; set; }
        public decimal? Subcontract { get; set; }
        public decimal? Other { get; set; }
        public decimal? TotalC2c { get; set; }
        public decimal? RevenueBud { get; set; }
        public decimal? LabourBud { get; set; }
        public decimal? MaterialBud { get; set; }
        public decimal? PlantBud { get; set; }
        public decimal? SubcontractBud { get; set; }
        public decimal? OtherBud { get; set; }
        public decimal? TotalBud { get; set; }
        public decimal? RevenueAct { get; set; }
        public decimal? LabourAct { get; set; }
        public decimal? MaterialAct { get; set; }
        public decimal? PlantAct { get; set; }
        public decimal? SubcontractAct { get; set; }
        public decimal? OtherAct { get; set; }
        public decimal? TotalAct { get; set; }
        public decimal? RevenueCom { get; set; }
        public decimal? LabourCom { get; set; }
        public decimal? MaterialCom { get; set; }
        public decimal? PlantCom { get; set; }
        public decimal? SubcontractCom { get; set; }
        public decimal? OtherCom { get; set; }
        public decimal? TotalCom { get; set; }
        public decimal? RevenueTot { get; set; }
        public decimal? LabourTot { get; set; }
        public decimal? MaterialTot { get; set; }
        public decimal? PlantTot { get; set; }
        public decimal? SubcontractTot { get; set; }
        public decimal? OtherTot { get; set; }
        public decimal? TotalTot { get; set; }
        public decimal? RevenueAcc { get; set; }
        public decimal? LabourAcc { get; set; }
        public decimal? MaterialAcc { get; set; }
        public decimal? PlantAcc { get; set; }
        public decimal? SubcontractAcc { get; set; }
        public decimal? OtherAcc { get; set; }
        public decimal RetentionTotal { get; set; }
        public decimal ApplicationTotal { get; set; }
        public decimal ValuationTotal { get; set; }
    }
}
