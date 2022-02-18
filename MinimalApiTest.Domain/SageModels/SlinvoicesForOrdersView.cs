using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlinvoicesForOrdersView
    {
        public string MmsslinOrderNumber { get; set; } = null!;
        public string MmsslinInvoiceNo { get; set; } = null!;
        public DateTime MmsslinInvoiceDate { get; set; }
        public double? MmsslinInvoiceValue { get; set; }
        public string MmsslinDocumentStatus { get; set; } = null!;
        public long MmsslinOrderReturnId { get; set; }
    }
}
