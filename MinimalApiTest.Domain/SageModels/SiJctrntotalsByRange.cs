using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJctrntotalsByRange
    {
        public long Sijctrnid { get; set; }
        public long? Sijcjobid { get; set; }
        public long? Sijcchdid { get; set; }
        public string? JobNumber { get; set; }
        public string? Costcode { get; set; }
        public string? HeaderType { get; set; }
        public string Transtype { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? Transdate { get; set; }
        public string? StockType { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? SopdocumentType { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Actual { get; set; }
        public decimal? Totalcosts { get; set; }
        public long? SijobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
        public int SiJcVariationId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Week { get; set; }
        public int? Year { get; set; }
        public DateTime? WeekStart { get; set; }
    }
}
