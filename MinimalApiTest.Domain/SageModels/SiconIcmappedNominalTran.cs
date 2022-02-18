using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcmappedNominalTran
    {
        public long SiconIcmappedNominalTranId { get; set; }
        public long? NominalAccountId { get; set; }
        public string NominalReference { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public decimal Urn { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string CompanyName { get; set; } = null!;
        public long? NlpostedNominalTranId { get; set; }
    }
}
