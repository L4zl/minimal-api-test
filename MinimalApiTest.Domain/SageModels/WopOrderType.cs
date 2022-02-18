using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopOrderType
    {
        public WopOrderType()
        {
            WopOrders = new HashSet<WopOrder>();
        }

        public long WopOrderTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<WopOrder> WopOrders { get; set; }
    }
}
