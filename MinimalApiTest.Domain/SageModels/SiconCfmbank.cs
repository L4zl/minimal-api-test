using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmbank
    {
        public long SiconCfmbankId { get; set; }
        public long? SiconCfmsectionId { get; set; }
        public long? CbaccountId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
