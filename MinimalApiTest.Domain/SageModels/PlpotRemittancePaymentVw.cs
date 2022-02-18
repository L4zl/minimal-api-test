using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpotRemittancePaymentVw
    {
        public DateTime DueDate { get; set; }
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal DiscountValue { get; set; }
        public string TransactionReference { get; set; } = null!;
        public long SystraderTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AllocatedValue { get; set; }
        public short DaysDiscountValid { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public long? PlproposedPaymentPostedTranId { get; set; }
        public decimal? DiscountToClaimValue { get; set; }
        public decimal? ToPayValue { get; set; }
        public string QueryCode { get; set; } = null!;
        public long PlsupplierAccountId { get; set; }
    }
}
