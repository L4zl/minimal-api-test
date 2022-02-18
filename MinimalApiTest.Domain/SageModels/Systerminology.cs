using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Systerminology
    {
        public Systerminology()
        {
            TstermExpensesConfigLinks = new HashSet<TstermExpensesConfigLink>();
            TstermTimesheetConfigLinks = new HashSet<TstermTimesheetConfigLink>();
        }

        public long TsterminologyId { get; set; }
        public string InternalName { get; set; } = null!;
        public string ExternalName { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TstermExpensesConfigLink> TstermExpensesConfigLinks { get; set; }
        public virtual ICollection<TstermTimesheetConfigLink> TstermTimesheetConfigLinks { get; set; }
    }
}
