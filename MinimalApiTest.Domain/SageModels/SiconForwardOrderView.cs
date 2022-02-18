using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconForwardOrderView
    {
        public string ItemCode { get; set; } = null!;
        public decimal ForwardOrderQuantity { get; set; }
    }
}
