using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sysuser
    {
        public Sysuser()
        {
            SysuserPermissions = new HashSet<SysuserPermission>();
        }

        public long SysuserId { get; set; }
        public int UserNumber { get; set; }

        public virtual ICollection<SysuserPermission> SysuserPermissions { get; set; }
    }
}
