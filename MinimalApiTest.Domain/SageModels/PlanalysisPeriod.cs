using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlanalysisPeriod
    {
        public PlanalysisPeriod()
        {
            PlsupplierPeriodValues = new HashSet<PlsupplierPeriodValue>();
        }

        public long PlanalysisPeriodId { get; set; }
        public string PeriodReference { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PlsupplierPeriodValue> PlsupplierPeriodValues { get; set; }
    }
}
