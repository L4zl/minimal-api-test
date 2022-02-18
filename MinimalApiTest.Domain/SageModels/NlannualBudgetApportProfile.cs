using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlannualBudgetApportProfile
    {
        public NlannualBudgetApportProfile()
        {
            NlaccountYearValues = new HashSet<NlaccountYearValue>();
            NlbudgetApportPeriodPrcnts = new HashSet<NlbudgetApportPeriodPrcnt>();
        }

        public long NlannualBudgetApportProfileId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlaccountYearValue> NlaccountYearValues { get; set; }
        public virtual ICollection<NlbudgetApportPeriodPrcnt> NlbudgetApportPeriodPrcnts { get; set; }
    }
}
