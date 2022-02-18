using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierBank
    {
        public long PlsupplierBankId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public string SortCode { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string AccountName { get; set; } = null!;
        public string BankPaymentReference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string? Ibannumber { get; set; }
        public string? Bicnumber { get; set; }
        public string? RollNumber { get; set; }
        public string? Bacsreference { get; set; }
        public string? AdditionalReference { get; set; }
        public string? NonUksortCode { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string? SagePaymentsIdentifier { get; set; }
        public string? SagePaymentsNationalBankIdentifier { get; set; }

        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
    }
}
