using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsdayOfWeek
    {
        public TsdayOfWeek()
        {
            TstimesheetConfigurations = new HashSet<TstimesheetConfiguration>();
        }

        public long TsdayOfWeekId { get; set; }
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<TstimesheetConfiguration> TstimesheetConfigurations { get; set; }
    }
}
