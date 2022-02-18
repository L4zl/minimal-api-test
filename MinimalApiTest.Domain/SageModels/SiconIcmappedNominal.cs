using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcmappedNominal
    {
        public long SiconIcmappedNominalId { get; set; }
        public string AccountReference { get; set; } = null!;
        public string CostCentre { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string MappedAccountReference { get; set; } = null!;
        public string MappedCostCentre { get; set; } = null!;
        public string MappedDepartment { get; set; } = null!;
        public string MappedName { get; set; } = null!;
        public long CompanyNumber { get; set; }
    }
}
