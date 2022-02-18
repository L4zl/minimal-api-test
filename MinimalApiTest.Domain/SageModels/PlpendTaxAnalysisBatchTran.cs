using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpendTaxAnalysisBatchTran
    {
        public long PlpendTaxAnalysisBatchTranId { get; set; }
        public long PlpendSupplierBatchTranId { get; set; }
        public long SystaxRateId { get; set; }
        public decimal GoodsValueBeforeDiscount { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal TaxOnGoodsValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string TaxAnalysisDetails { get; set; } = null!;

        public virtual PlpendSupplierBatchTran PlpendSupplierBatchTran { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
    }
}
