using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetsView
    {
        public long Code { get; set; }
        public string? Name { get; set; }
        public decimal? CostValue { get; set; }
        public decimal? AccumulatedDepreciation { get; set; }
        public decimal? NetBookValue { get; set; }
        public string? CategoryDescription { get; set; }
        public string? SubCategoryDescription { get; set; }
    }
}
