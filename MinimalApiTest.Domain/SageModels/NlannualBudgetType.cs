using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlannualBudgetType
    {
        public NlannualBudgetType()
        {
            NlaccountYearValues = new HashSet<NlaccountYearValue>();
        }

        public long NlannualBudgetTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlaccountYearValue> NlaccountYearValues { get; set; }
    }
}
