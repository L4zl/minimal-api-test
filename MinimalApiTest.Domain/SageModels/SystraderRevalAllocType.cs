using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderRevalAllocType
    {
        public SystraderRevalAllocType()
        {
            PlhistRevalAllocationTrans = new HashSet<PlhistRevalAllocationTran>();
            PlrevalAllocationTrans = new HashSet<PlrevalAllocationTran>();
            SlhistRevalAllocationTrans = new HashSet<SlhistRevalAllocationTran>();
            SlrevalAllocationTrans = new HashSet<SlrevalAllocationTran>();
        }

        public long SystraderRevalAllocTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlhistRevalAllocationTran> PlhistRevalAllocationTrans { get; set; }
        public virtual ICollection<PlrevalAllocationTran> PlrevalAllocationTrans { get; set; }
        public virtual ICollection<SlhistRevalAllocationTran> SlhistRevalAllocationTrans { get; set; }
        public virtual ICollection<SlrevalAllocationTran> SlrevalAllocationTrans { get; set; }
    }
}
