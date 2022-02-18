using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopadditionalChargeView
    {
        public string MmssacCode { get; set; } = null!;
        public string MmssacChargeName { get; set; } = null!;
        public string MmssacTaxName { get; set; } = null!;
        public string? MmssacLineTotalValue { get; set; }
        public string? MmssacLineTaxValue { get; set; }
        public long MmssacSoporderReturnId { get; set; }
    }
}
