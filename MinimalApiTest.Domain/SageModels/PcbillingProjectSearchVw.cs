using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcbillingProjectSearchVw
    {
        public long BlbillId { get; set; }
        public string BillNumber { get; set; } = null!;
        public string BillType { get; set; } = null!;
        public string BillStatus { get; set; } = null!;
        public string AccountReference { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public decimal TotalNetValue { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalGrossValue { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal TotalDiscountedNetValue { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? CreditNo { get; set; }
        public DateTime? CreditDate { get; set; }
        public string? CreditStatus { get; set; }
    }
}
