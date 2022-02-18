using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpaymentGroup
    {
        public PlpaymentGroup()
        {
            PlpendSupplierAccounts = new HashSet<PlpendSupplierAccount>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
        }

        public long PlpaymentGroupId { get; set; }
        public long PlpaymentDocumentTypeId { get; set; }
        public short PaymentGroupNumber { get; set; }
        public string Description { get; set; } = null!;
        public bool PostToLedgerOnPaymentRun { get; set; }
        public bool UseThisWhenSinglePaymentGroup { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool SummarisePayments { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool IsSagePaymentsGroup { get; set; }

        public virtual PlpaymentDocumentType PlpaymentDocumentType { get; set; } = null!;
        public virtual ICollection<PlpendSupplierAccount> PlpendSupplierAccounts { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
    }
}
