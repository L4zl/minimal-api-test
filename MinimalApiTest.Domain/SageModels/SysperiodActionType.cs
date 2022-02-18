using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysperiodActionType
    {
        public SysperiodActionType()
        {
            SysperiodActions = new HashSet<SysperiodAction>();
        }

        public long SysperiodActionTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysperiodAction> SysperiodActions { get; set; }
    }
}
