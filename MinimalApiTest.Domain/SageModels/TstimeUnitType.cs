using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimeUnitType
    {
        public TstimeUnitType()
        {
            TstimesheetConfigurations = new HashSet<TstimesheetConfiguration>();
        }

        public long TstimeUnitTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TstimesheetConfiguration> TstimesheetConfigurations { get; set; }
    }
}
