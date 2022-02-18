using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFainsuranceCategory
    {
        public long InsuranceCategoryId { get; set; }
        public string? InsuranceCategoryCode { get; set; }
        public string? InsuranceCategoryName { get; set; }
        public bool Removed { get; set; }
    }
}
