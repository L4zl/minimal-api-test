using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetDepNominalsView
    {
        public long FixedAssetId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? SerialNumber { get; set; }
        public long? BsnlnominalAccountId { get; set; }
        public string? BsaccountNumber { get; set; }
        public string? BsaccountCostCentre { get; set; }
        public string? BsaccountDepartment { get; set; }
        public string? BsaccountName { get; set; }
        public string? PlaccountNumber { get; set; }
        public string? PlaccountCostCentre { get; set; }
        public string? PlaccountDepartment { get; set; }
        public string? PlaccountName { get; set; }
    }
}
