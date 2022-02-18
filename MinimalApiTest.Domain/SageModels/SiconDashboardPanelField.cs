using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDashboardPanelField
    {
        public long SiconDashboardPanelFieldId { get; set; }
        public long? SiconDashboardPanelId { get; set; }
        public int? FieldIndex { get; set; }
        public bool? Enabled { get; set; }
        public string? Label { get; set; }
        public string? Sqlquery { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? ColourCoding { get; set; }
    }
}
