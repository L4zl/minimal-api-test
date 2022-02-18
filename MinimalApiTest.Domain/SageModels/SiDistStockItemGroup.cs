using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiDistStockItemGroup
    {
        public long SiDistStockItemGroupId { get; set; }
        public string? GroupName { get; set; }
        public string? Information { get; set; }
        public string? Name1 { get; set; }
        public string? Separator1 { get; set; }
        public string? Name2 { get; set; }
        public string? Separator2 { get; set; }
        public string? Name3 { get; set; }
        public string? Separator3 { get; set; }
        public string? Name4 { get; set; }
        public string? Separator4 { get; set; }
        public string? Name5 { get; set; }
        public string? Separator5 { get; set; }
        public string? Name6 { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? GroupCode { get; set; }
        public bool IncludeName1InName { get; set; }
        public bool IncludeSeparator1InName { get; set; }
        public bool IncludeName2InName { get; set; }
        public bool IncludeSeparator2InName { get; set; }
        public bool IncludeName3InName { get; set; }
        public bool IncludeSeparator3InName { get; set; }
        public bool IncludeName4InName { get; set; }
        public bool IncludeSeparator4InName { get; set; }
        public bool IncludeName5InName { get; set; }
        public bool IncludeSeparator5InName { get; set; }
        public bool IncludeName6InName { get; set; }
        public bool IncludeSeparator6InName { get; set; }
    }
}
