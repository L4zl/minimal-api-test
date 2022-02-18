using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcnominalCode
    {
        public long SiconIcnominalCodeId { get; set; }
        public bool ExcludeTax { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
