using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsPaymentHeader
    {
        public long SiconDdsPaymentHeaderId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SopinvoiceCreditId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public long? SiconDdsPaymentHeaderStatusId { get; set; }
        public long? SiconDdsPaymentMethodId { get; set; }
        public long? SiconDdsPaymentHeaderSourceId { get; set; }
        public DateTime? FirstPaymentDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
