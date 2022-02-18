using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlunauthNominalAnalysisItem
    {
        public long PlunauthNominalAnalysisItemId { get; set; }
        public long PlpostedSupplierTranId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public string TransactionAnalysisCode { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool IsPrimary { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlpostedSupplierTran PlpostedSupplierTran { get; set; } = null!;
    }
}
