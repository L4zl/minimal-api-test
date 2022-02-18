using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsHeaderEnquiryView
    {
        public string OrderReturnNo { get; set; } = null!;
        public string InvoiceCreditNo { get; set; } = null!;
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string PaymentHeaderStatus { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public string PaymentHeaderSource { get; set; } = null!;
        public DateTime? FirstPaymentDate { get; set; }
        public long SiconDdsPaymentHeaderId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SopinvoiceCreditId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public decimal SalControlValueInBaseCurrency { get; set; }
        public long? SiconDdsPaymentHeaderStatusId { get; set; }
        public long? SiconDdsPaymentMethodId { get; set; }
        public long? SiconDdsPaymentHeaderSourceId { get; set; }
    }
}
