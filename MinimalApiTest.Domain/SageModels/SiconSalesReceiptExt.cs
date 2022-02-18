using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesReceiptExt
    {
        public long SiconSalesReceiptExtId { get; set; }
        public long Urn { get; set; }
        public string? CustomerName { get; set; }
        public long? PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; } = null!;
        public string PaymentMethodDescription { get; set; } = null!;
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
