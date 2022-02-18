using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmbadDebt
    {
        public long SiconCfmbadDebtId { get; set; }
        public long? BadDebtForeignId { get; set; }
        public string BadDebtSource { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
