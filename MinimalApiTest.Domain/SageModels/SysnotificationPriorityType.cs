using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysnotificationPriorityType
    {
        public SysnotificationPriorityType()
        {
            Sysnotifications = new HashSet<Sysnotification>();
        }

        public long SysnotificationPriorityTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Sysnotification> Sysnotifications { get; set; }
    }
}
