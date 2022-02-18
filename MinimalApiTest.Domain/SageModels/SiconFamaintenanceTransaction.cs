using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFamaintenanceTransaction
    {
        public long TransactionId { get; set; }
        public long FixedAssetId { get; set; }
        public long? SiconFasupplierId { get; set; }
        public DateTime? Date { get; set; }
        public string? Details { get; set; }
        public decimal? Cost { get; set; }
        public long? PurchaseInvoiceUrn { get; set; }
    }
}
