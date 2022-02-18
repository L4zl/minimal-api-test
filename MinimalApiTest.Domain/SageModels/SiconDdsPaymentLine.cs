using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsPaymentLine
    {
        public long SiconDdsPaymentLineId { get; set; }
        public long? SiconDdsPaymentHeaderId { get; set; }
        public long? SiconDdsPaymentLineStatusId { get; set; }
        public long? SiconDdsBacsvalueTypeId { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal AllocatedAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmount { get; set; }
        public long? CreditNoteUrn { get; set; }
        public string CreditNoteReason { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public DateTime? ProcessingDate { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
