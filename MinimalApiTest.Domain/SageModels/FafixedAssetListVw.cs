using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class FafixedAssetListVw
    {
        public long FaassetId { get; set; }
        public string AssetNumber { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BsdepreciationAccountNumber { get; set; } = null!;
        public string BsdepreciationAccountCostCentre { get; set; } = null!;
        public string BsdepreciationAccountDepartment { get; set; } = null!;
        public string PldepreciationAccountNumber { get; set; } = null!;
        public string PldepreciationAccountCostCentre { get; set; } = null!;
        public string PldepreciationAccountDepartment { get; set; } = null!;
        public DateTime? AcquiredDate { get; set; }
        public decimal InitialValue { get; set; }
        public decimal ResidualBalance { get; set; }
        public decimal NetBookBalance { get; set; }
        public long? FadepreciationMethodId { get; set; }
        public decimal DepreciationPercent { get; set; }
        public long ExpectedLife { get; set; }
        public DateTime? LastDepreciationDate { get; set; }
        public string Manager { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Analysis1 { get; set; } = null!;
        public string Analysis2 { get; set; } = null!;
        public string Analysis3 { get; set; } = null!;
        public DateTime? DisposedDate { get; set; }
        public bool Active { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal? DisposalPosted { get; set; }
        public decimal? TotalDepreciationPosted { get; set; }
    }
}
