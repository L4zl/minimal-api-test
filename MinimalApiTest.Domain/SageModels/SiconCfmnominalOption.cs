using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmnominalOption
    {
        public long SiconCfmnominalOptionId { get; set; }
        public long? NlnominalAccountId { get; set; }
        public bool AddVat { get; set; }
        public long? SystaxRateId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
