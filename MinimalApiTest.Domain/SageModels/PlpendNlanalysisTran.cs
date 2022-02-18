using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpendNlanalysisTran
    {
        public long PlpendNlanalysisTranId { get; set; }
        public long PlpendSupplierTranId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalAccountCostCentre { get; set; } = null!;
        public string NominalAccountDepartment { get; set; } = null!;
        public string NominalAnalysisNarrative { get; set; } = null!;
        public decimal TransactionValue { get; set; }
        public string? TransactionAnalysisCode { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlpendSupplierTran PlpendSupplierTran { get; set; } = null!;
    }
}
