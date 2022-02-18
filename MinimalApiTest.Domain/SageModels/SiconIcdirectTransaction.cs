using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcdirectTransaction
    {
        public long SiconIcdirectTransactionId { get; set; }
        public string Reference { get; set; } = null!;
        public string CostCentre { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public decimal Value { get; set; }
        public decimal TaxValue { get; set; }
    }
}
