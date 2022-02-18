using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconGridViewColumn
    {
        public long SiconGridViewColumnId { get; set; }
        public long SiconGridViewId { get; set; }
        public string? Caption { get; set; }
        public string? Variable { get; set; }
        public bool? ShowTotals { get; set; }
        public int? Alignment { get; set; }
        public int? Order { get; set; }
    }
}
