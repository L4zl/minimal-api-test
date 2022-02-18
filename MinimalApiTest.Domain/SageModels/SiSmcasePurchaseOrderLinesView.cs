using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcasePurchaseOrderLinesView
    {
        public long? SiSmcaseId { get; set; }
        public string Ponumber { get; set; } = null!;
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long ForeignId { get; set; }
        public int Type { get; set; }
        public string TypeDesc { get; set; } = null!;
    }
}
