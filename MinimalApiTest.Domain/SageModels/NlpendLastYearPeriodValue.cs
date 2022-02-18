using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendLastYearPeriodValue
    {
        public long NlpendLastYearPeriodValueId { get; set; }
        public long NlpendNominalAccountId { get; set; }
        public short PeriodNumber { get; set; }
        public decimal ActualLastYearBalance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlpendNominalAccount NlpendNominalAccount { get; set; } = null!;
    }
}
