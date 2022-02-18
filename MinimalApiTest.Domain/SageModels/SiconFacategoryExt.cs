using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFacategoryExt
    {
        public long SiconFacategoryExtId { get; set; }
        public long SiconFacategoryId { get; set; }
        public long NlnominalAccountId { get; set; }
        public int? NominalType { get; set; }
        public decimal? Percentage { get; set; }
    }
}
