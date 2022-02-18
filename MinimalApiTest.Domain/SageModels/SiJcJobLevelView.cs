using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcJobLevelView
    {
        public long ItemId { get; set; }
        public long? ParentId { get; set; }
        public string Type { get; set; } = null!;
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public int? CheckedCount { get; set; }
        public int? CheckListCount { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Cost { get; set; }
        public decimal? PercentCompleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? ProjectId { get; set; }
    }
}
