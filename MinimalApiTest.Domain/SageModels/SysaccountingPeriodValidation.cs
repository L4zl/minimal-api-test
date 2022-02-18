using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountingPeriodValidation
    {
        public SysaccountingPeriodValidation()
        {
            Syssettings = new HashSet<Syssetting>();
        }

        public long SysaccountingPeriodValidationId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Syssetting> Syssettings { get; set; }
    }
}
