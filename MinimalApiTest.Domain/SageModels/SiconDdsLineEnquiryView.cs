using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsLineEnquiryView
    {
        public DateTime? PaymentDueDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal AllocatedAmount { get; set; }
        public string CreditNoteReason { get; set; } = null!;
        public long? CreditNoteUrn { get; set; }
        public string Memo { get; set; } = null!;
        public string PaymentLineStatus { get; set; } = null!;
        public long SiconDdsPaymentLineId { get; set; }
        public long? SiconDdsPaymentHeaderId { get; set; }
        public long? SiconDdsPaymentLineStatusId { get; set; }
        public long? SiconDdsBacsvalueTypeId { get; set; }
        public string BacsvalueType { get; set; } = null!;
    }
}
