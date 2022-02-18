using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountMemoType
    {
        public SysaccountMemoType()
        {
            PcprojectItemMemos = new HashSet<PcprojectItemMemo>();
            PlaccountMemos = new HashSet<PlaccountMemo>();
            SlaccountMemos = new HashSet<SlaccountMemo>();
        }

        public long SysaccountMemoTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PcprojectItemMemo> PcprojectItemMemos { get; set; }
        public virtual ICollection<PlaccountMemo> PlaccountMemos { get; set; }
        public virtual ICollection<SlaccountMemo> SlaccountMemos { get; set; }
    }
}
