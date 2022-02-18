using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetInvoicesView
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime InvoiceCreditDate { get; set; }
        public decimal? Amount { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public string? OrderReturnNo { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public DateTime? BillCoverFromDate { get; set; }
        public DateTime? BillCoverToDate { get; set; }
        public decimal? DaysOnHire { get; set; }
        public short PeriodNumber { get; set; }
    }
}
