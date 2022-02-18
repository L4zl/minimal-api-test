using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PaymentInvoiceStatus
    {
        public PaymentInvoiceStatus()
        {
            SoppaymentArches = new HashSet<SoppaymentArch>();
            Soppayments = new HashSet<Soppayment>();
        }

        public long PaymentInvoiceStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoppaymentArch> SoppaymentArches { get; set; }
        public virtual ICollection<Soppayment> Soppayments { get; set; }
    }
}
