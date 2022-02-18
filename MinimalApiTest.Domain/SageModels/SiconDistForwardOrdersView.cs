using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistForwardOrdersView
    {
        public string ItemCode { get; set; } = null!;
        public long DocumentTypeId { get; set; }
        public decimal Quantity { get; set; }
    }
}
