using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RequestedDeliveryDate
    {
        public long RequestedDeliveryDateId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal Quantity { get; set; }
        public long PoporderReturnLineId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoporderReturnLine PoporderReturnLine { get; set; } = null!;
    }
}
