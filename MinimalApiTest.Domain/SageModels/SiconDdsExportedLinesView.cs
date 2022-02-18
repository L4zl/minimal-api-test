using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsExportedLinesView
    {
        public DateTime? PaymentDueDate { get; set; }
        public int? DaysOverdue { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string OrderReturnNo { get; set; } = null!;
        public string InvoiceCreditNo { get; set; } = null!;
        public string QueryCode { get; set; } = null!;
        public decimal PaymentAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal AllocatedAmount { get; set; }
        public decimal? OutstandingAmount { get; set; }
        public string BacsvalueTypeName { get; set; } = null!;
        public string BacsvalueTypeFriendlyName { get; set; } = null!;
        public string PaymentLineStatusName { get; set; } = null!;
        public string PaymentLineStatusFriendlyName { get; set; } = null!;
        public string PaymentMethodName { get; set; } = null!;
        public string PaymentMethodFriendlyName { get; set; } = null!;
        public string PaymentSourceName { get; set; } = null!;
        public string PaymentSourceFriendlyName { get; set; } = null!;
        public long? SoporderReturnId { get; set; }
        public long? SopinvoiceCreditId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SiconDdsPaymentLineId { get; set; }
        public long? SiconDdsPaymentHeaderId { get; set; }
        public long? SiconDdsPaymentLineStatusId { get; set; }
        public long? SiconDdsBacsvalueTypeId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public long SiconDdsPaymentMethodId { get; set; }
        public long? SiconDdsPaymentHeaderSourceId { get; set; }
    }
}
