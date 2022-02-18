using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsOutstandingInvoiceView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public long? CustomerPaymentMethodId { get; set; }
        public string CustomerPaymentMethodName { get; set; } = null!;
        public string CustomerPaymentMethodFriend { get; set; } = null!;
        public string TransactionTypeName { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal AllocatedValue { get; set; }
        public string QueryCode { get; set; } = null!;
        public long UniqueReferenceNumber { get; set; }
        public long SlpostedCustomerTranId { get; set; }
        public long Source { get; set; }
        public long? TransactionPaymentMethodId { get; set; }
        public string TransactionPaymentMethodName { get; set; } = null!;
        public string TransactionPaymentMethodFriend { get; set; } = null!;
        public string SysmoduleName { get; set; } = null!;
    }
}
