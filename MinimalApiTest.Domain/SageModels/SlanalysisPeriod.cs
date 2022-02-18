using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlanalysisPeriod
    {
        public SlanalysisPeriod()
        {
            SlcustomerPeriodValues = new HashSet<SlcustomerPeriodValue>();
        }

        public long SlanalysisPeriodId { get; set; }
        public string PeriodReference { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SlcustomerPeriodValue> SlcustomerPeriodValues { get; set; }
    }
}
