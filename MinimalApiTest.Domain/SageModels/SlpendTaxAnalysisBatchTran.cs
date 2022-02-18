﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlpendTaxAnalysisBatchTran
    {
        public long SlpendTaxAnalysisBatchTranId { get; set; }
        public long SlpendCustomerBatchTranId { get; set; }
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

        public virtual SlpendCustomerBatchTran SlpendCustomerBatchTran { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
    }
}
