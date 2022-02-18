using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoppaymentMethod
    {
        public SoppaymentMethod()
        {
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
        }

        public long SoppaymentMethodId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? PaymentBankAccountId { get; set; }
        public string? PaymentNominalAccountRef { get; set; }
        public string? PaymentNominalCostCentre { get; set; }
        public string? PaymentNominalDepartment { get; set; }
        public long? PaymentNominalCodeId { get; set; }
        public long? CurrencyId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool CardProcessingMethod { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Syscurrency? Currency { get; set; }
        public virtual Cbaccount? PaymentBankAccount { get; set; }
        public virtual NlnominalAccount? PaymentNominalCode { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
    }
}
