using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvCredNominalItem
    {
        public long SopinvCredNominalItemId { get; set; }
        public long SopinvoiceCreditId { get; set; }
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public decimal NominalValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SopinvoiceCredit SopinvoiceCredit { get; set; } = null!;
    }
}
