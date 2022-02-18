using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvCredNominalItem
    {
        public long InvinvCredNominalItemId { get; set; }
        public long InvinvoiceCreditId { get; set; }
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public decimal NominalValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual InvinvoiceCredit InvinvoiceCredit { get; set; } = null!;
    }
}
