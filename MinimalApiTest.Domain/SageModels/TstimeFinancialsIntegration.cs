using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimeFinancialsIntegration
    {
        public long TsfinancialsIntegrationId { get; set; }
        public bool IsIntegrated { get; set; }
        public bool PostAutomatically { get; set; }
        public long TspostingMethodId { get; set; }
        public bool EnterNominalAccOnTimesheet { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string? DefaultNominalAccountNumber { get; set; }
        public string? DefaultNominalAccountCostCentre { get; set; }
        public string? DefaultNominalAccountDepartment { get; set; }
        public string? NominalControlAccountNumber { get; set; }
        public string? NominalControlAccountCostCentre { get; set; }
        public string? NominalControlAccountDepartment { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TspostingMethodType TspostingMethod { get; set; } = null!;
    }
}
