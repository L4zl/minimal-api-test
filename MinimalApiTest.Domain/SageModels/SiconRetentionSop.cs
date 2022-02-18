using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionSop
    {
        public long SiconRetentionSopid { get; set; }
        public long? SalesOrderReturnId { get; set; }
        public long? SopretentionLineId { get; set; }
        public decimal? RetentionPc1 { get; set; }
        public decimal? RetentionPc2 { get; set; }
        public decimal? RetentionPc3 { get; set; }
        public decimal? RetentionPc4 { get; set; }
        public decimal? RetentionValue1 { get; set; }
        public decimal? RetentionValue2 { get; set; }
        public decimal? RetentionValue3 { get; set; }
        public decimal? RetentionValue4 { get; set; }
        public DateTime? RetentionDate1 { get; set; }
        public DateTime? RetentionDate2 { get; set; }
        public DateTime? RetentionDate3 { get; set; }
        public DateTime? RetentionDate4 { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SiJcVariationId { get; set; }
        public long? SiJcPhaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
    }
}
