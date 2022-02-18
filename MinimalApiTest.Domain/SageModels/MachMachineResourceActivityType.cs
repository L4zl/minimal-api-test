using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MachMachineResourceActivityType
    {
        public MachMachineResourceActivityType()
        {
            MachMachineResourceActivities = new HashSet<MachMachineResourceActivity>();
        }

        public long MachMachineResourceActivityTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MachMachineResourceActivity> MachMachineResourceActivities { get; set; }
    }
}
