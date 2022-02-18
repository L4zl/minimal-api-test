using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysnotificationStatusType
    {
        public SysnotificationStatusType()
        {
            Sysnotifications = new HashSet<Sysnotification>();
        }

        public long SysnotificationStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Sysnotification> Sysnotifications { get; set; }
    }
}
