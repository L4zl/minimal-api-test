using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoporderLineView
    {
        public long SoporderReturnLineId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public long SoporderReturnId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
    }
}
