using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpFinancialsIntegration
    {
        public long TsexpFinancialsIntegrationId { get; set; }
        public bool IsIntegrated { get; set; }
        public bool PostAutomatically { get; set; }
        public string NominalControlAccountNumber { get; set; } = null!;
        public string? NominalControlAccountCostCentre { get; set; }
        public string? NominalControlAccountDepartment { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
