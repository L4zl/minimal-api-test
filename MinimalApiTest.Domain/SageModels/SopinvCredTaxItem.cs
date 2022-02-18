using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvCredTaxItem
    {
        public long SopinvCredTaxItemId { get; set; }
        public long SopinvoiceCreditId { get; set; }
        public long TaxCodeId { get; set; }
        public decimal CoreGoodsValue { get; set; }
        public decimal CoreDiscountValue { get; set; }
        public decimal CoreTaxValue { get; set; }
        public decimal CoreGrossValue { get; set; }
        public decimal GoodsValue { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TaxValue { get; set; }
        public decimal GrossValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal TaxRate { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public decimal DiscountedTaxValue { get; set; }
        public decimal CoreDiscountedTaxValue { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopinvoiceCredit SopinvoiceCredit { get; set; } = null!;
        public virtual SystaxRate TaxCode { get; set; } = null!;
    }
}
