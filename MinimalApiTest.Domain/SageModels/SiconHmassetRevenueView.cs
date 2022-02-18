using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetRevenueView
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public decimal? LastYearAmount { get; set; }
        public decimal? CurrentYearAmount { get; set; }
        public decimal? LifeAmount { get; set; }
    }
}
