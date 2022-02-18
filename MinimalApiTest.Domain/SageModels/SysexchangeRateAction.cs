using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysexchangeRateAction
    {
        public SysexchangeRateAction()
        {
            SysexchangeRateHistories = new HashSet<SysexchangeRateHistory>();
        }

        public long SysexchangeRateActionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysexchangeRateHistory> SysexchangeRateHistories { get; set; }
    }
}
