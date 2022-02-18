using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWablabelInfo
    {
        public long SiconWablabelInfoId { get; set; }
        public int LabelTargetId { get; set; }
        public int LabelContextId { get; set; }
        public string Name { get; set; } = null!;
        public string? Default2011Path { get; set; }
        public string? Default2013Path { get; set; }
        public string? Override2011Path { get; set; }
        public string? Override2013Path { get; set; }
        public string OverridePrinter { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public bool? IsDefault { get; set; }
        public long? CustomerId { get; set; }
        public long? ProductGroupId { get; set; }
        public long? StockItemId { get; set; }
    }
}
