using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmsectionType
    {
        public long SiconCfmsectionTypeId { get; set; }
        public string Title { get; set; } = null!;
        public string ResourceKey { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string Type { get; set; } = null!;
        public bool AllowCurrencyFilter { get; set; }
        public bool AllowBadDebtFilter { get; set; }
    }
}
