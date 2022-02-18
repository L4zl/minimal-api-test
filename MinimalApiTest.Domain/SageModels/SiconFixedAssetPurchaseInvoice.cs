using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetPurchaseInvoice
    {
        public long PurchaseInvoiceId { get; set; }
        public long FixedAssetId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public DateTime? DateTimePosted { get; set; }
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
    }
}
