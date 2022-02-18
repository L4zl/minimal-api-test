using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SijcnljournalItem
    {
        public long SijcnljournalItemId { get; set; }
        public string? HoldType { get; set; }
        public long? ParentId { get; set; }
        public int? LineIndex { get; set; }
        public long? SijcjobId { get; set; }
        public long? SijcchdId { get; set; }
        public long? SijcphaseId { get; set; }
        public long? SijcstageId { get; set; }
        public long? SijcsubStageId { get; set; }
        public long? SiOperationId { get; set; }
        public long? SijcvariationId { get; set; }
        public long? LineId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
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
    }
}
