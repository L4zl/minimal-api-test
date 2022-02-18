using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsuserProfile
    {
        public long TsuserProfileId { get; set; }
        public long TspersonId { get; set; }
        public long TsuserStatusId { get; set; }
        public decimal ExpensesAuthorisationLimit { get; set; }
        public bool CouldAuthorise { get; set; }
        public bool CanEnterTimesheetByProxy { get; set; }
        public bool CanEnterExpensesByProxy { get; set; }
        public string PostingNlcostCentre { get; set; } = null!;
        public string PostingNldepartment { get; set; } = null!;
        public DateTime? LastUpdate { get; set; }
        public string? LastUpdateBy { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? SysproviderConfigurationId { get; set; }
        public bool CanImportFromPayroll { get; set; }
        public DateTime LastDateWeeklyTsentry { get; set; }
        public string? PayrollProviderName { get; set; }
        public bool WteallowAmendChargeRates { get; set; }
        public bool WteallowAmendCostRates { get; set; }
        public bool WteallowAmendPayRates { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysproviderConfiguration? SysproviderConfiguration { get; set; }
        public virtual Tsperson Tsperson { get; set; } = null!;
        public virtual TsuserStatus TsuserStatus { get; set; } = null!;
    }
}
