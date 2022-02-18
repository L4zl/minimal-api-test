using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvoiceCreditAddress
    {
        public InvinvoiceCreditAddress()
        {
            InvinvoiceCreditInvbillingAddresses = new HashSet<InvinvoiceCredit>();
            InvinvoiceCreditInvdeliveryAddresses = new HashSet<InvinvoiceCredit>();
        }

        public long InvinvoiceCreditAddressId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string PostalName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<InvinvoiceCredit> InvinvoiceCreditInvbillingAddresses { get; set; }
        public virtual ICollection<InvinvoiceCredit> InvinvoiceCreditInvdeliveryAddresses { get; set; }
    }
}
