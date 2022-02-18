using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmPeriodFrequency
    {
        public MsmPeriodFrequency()
        {
            MachMachineResourceCalibrationIntervalPeriods = new HashSet<MachMachineResource>();
            MachMachineResourceServiceIntervalPeriods = new HashSet<MachMachineResource>();
            ToolToolingResourceCalibrationIntervalPeriods = new HashSet<ToolToolingResource>();
            ToolToolingResourceServiceIntervalPeriods = new HashSet<ToolToolingResource>();
        }

        public long MsmPeriodFrequencyId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MachMachineResource> MachMachineResourceCalibrationIntervalPeriods { get; set; }
        public virtual ICollection<MachMachineResource> MachMachineResourceServiceIntervalPeriods { get; set; }
        public virtual ICollection<ToolToolingResource> ToolToolingResourceCalibrationIntervalPeriods { get; set; }
        public virtual ICollection<ToolToolingResource> ToolToolingResourceServiceIntervalPeriods { get; set; }
    }
}
