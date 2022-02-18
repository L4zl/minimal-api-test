using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlproposedPayment
    {
        public PlproposedPayment()
        {
            PlproposedPaymentPostedTrans = new HashSet<PlproposedPaymentPostedTran>();
        }

        public long PlproposedPaymentId { get; set; }
        public decimal BankChequeValue { get; set; }
        public decimal BankChequeDiscountValue { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public long? SupplierPaymentId { get; set; }
        public long? BankPaymentId { get; set; }
        public DateTime DocumentDate { get; set; }
        public bool MaxChequeValueExceeded { get; set; }
        public long PlsupplierAccountId { get; set; }
        public bool PaidFlag { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual CbpostedAccountTran? BankPayment { get; set; }
        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual PlpostedSupplierTran? SupplierPayment { get; set; }
        public virtual ICollection<PlproposedPaymentPostedTran> PlproposedPaymentPostedTrans { get; set; }
    }
}
