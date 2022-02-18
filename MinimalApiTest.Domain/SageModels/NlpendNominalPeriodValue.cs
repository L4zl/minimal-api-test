using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalPeriodValue
    {
        public long NlpendNominalPeriodValueId { get; set; }
        public long NlpendNominalAccountId { get; set; }
        public short PeriodNumber { get; set; }
        public decimal ActualThisYearBalance { get; set; }
        public decimal BudgetThisYearBalance { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long NlpendNominalYearValueId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlpendNominalAccount NlpendNominalAccount { get; set; } = null!;
        public virtual NlpendNominalYearValue NlpendNominalYearValue { get; set; } = null!;
    }
}
