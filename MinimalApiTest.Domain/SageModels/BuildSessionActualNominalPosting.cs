using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BuildSessionActualNominalPosting
    {
        public long BuildSessionActualNominalPostingId { get; set; }
        public long BomBuildSessionId { get; set; }
        public bool DebitTransaction { get; set; }
        public decimal Cost { get; set; }
        public long NominalAccountId { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalAccountCostCentre { get; set; } = null!;
        public string NominalAccountDepartment { get; set; } = null!;
        public long? Urn { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildSession BomBuildSession { get; set; } = null!;
    }
}
