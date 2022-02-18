using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIcnominalAnalysisItem
    {
        public long SiconIcnominalAnalysisItemId { get; set; }
        public string NominalName { get; set; } = null!;
        public string? Narrative { get; set; }
        public decimal Value { get; set; }
        public decimal TaxValue { get; set; }
        public string PccostCode { get; set; } = null!;
        public string PccostItem { get; set; } = null!;
        public bool IsControlAccount { get; set; }
        public bool IsProjectUsed { get; set; }
        public int NominalIndex { get; set; }
        public string TransactionAnalysisCode { get; set; } = null!;
    }
}
