using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderLinesDespatchView
    {
        public string? MmssoldItemCode { get; set; }
        public string MmssoldOrderDocumentNumber { get; set; } = null!;
        public string MmssoldDespatchReceiptNo { get; set; } = null!;
        public DateTime MmssoldDespatchReceiptDate { get; set; }
        public string MmssoldDespatchedBy { get; set; } = null!;
        public double? MmssoldDespatchReceiptQuantity { get; set; }
        public long MmssoldCustomerId { get; set; }
        public long MmssoldSoporderReturnId { get; set; }
    }
}
