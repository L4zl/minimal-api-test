using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopadditionalCharge
    {
        public long SopadditionalChargeId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal ChargeValue { get; set; }
        public bool ApplyOrderValueDiscount { get; set; }
        public long TaxCodeId { get; set; }
        public long? NominalCodeId { get; set; }
        public decimal NotionalCostValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalAccount? NominalCode { get; set; }
        public virtual SystaxRate TaxCode { get; set; } = null!;
    }
}
