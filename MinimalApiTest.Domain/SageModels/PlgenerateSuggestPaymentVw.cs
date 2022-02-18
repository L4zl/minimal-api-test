using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlgenerateSuggestPaymentVw
    {
        public long PlpostedSupplierTranId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal AllocatedValue { get; set; }
        public decimal DiscountValue { get; set; }
        public short DaysDiscountValid { get; set; }
        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public bool AccountIsOnHold { get; set; }
        public string QueryCode { get; set; } = null!;
    }
}
