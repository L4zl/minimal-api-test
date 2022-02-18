using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpendNlanalysisBatchTran
    {
        public long PlpendNlanalysisBatchTranId { get; set; }
        public long PlpendSupplierBatchTranId { get; set; }
        public decimal TransactionValue { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalAccountCostCentre { get; set; } = null!;
        public string NominalAccountDepartment { get; set; } = null!;
        public string NominalAnalysisNarrative { get; set; } = null!;
        public string NominalAccountName { get; set; } = null!;
        public string TransactionAnalysisCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlpendSupplierBatchTran PlpendSupplierBatchTran { get; set; } = null!;
    }
}
