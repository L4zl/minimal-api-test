using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalYearValue
    {
        public NlpendNominalYearValue()
        {
            NlpendNominalPeriodValues = new HashSet<NlpendNominalPeriodValue>();
        }

        public long NlpendNominalYearValueId { get; set; }
        public long NlpendNominalAccountId { get; set; }
        public string BudgetType { get; set; } = null!;
        public int YearRelativeToCurrentYear { get; set; }
        public string AnnualBudgetApportProfile { get; set; } = null!;
        public decimal BudgetValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlpendNominalAccount NlpendNominalAccount { get; set; } = null!;
        public virtual ICollection<NlpendNominalPeriodValue> NlpendNominalPeriodValues { get; set; }
    }
}
